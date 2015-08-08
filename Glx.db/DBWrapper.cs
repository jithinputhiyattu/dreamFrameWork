/***
 * 
 * @Filename        :   DBWrapper.cs
 * @Description     :   DB Manager
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/0:01
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Glx.Logger;

namespace Glx.DB
{
    /// <summary>
    /// DBWrapper class
    /// </summary>
    public static class DBWrapper
    {
        public static SqlConnection _SqlConnection;
        public static SqlDataReader _SqlDataReader;
        private static string _sDBStringPath;
        private static string _sDBConectionString;

        /// <summary>
        /// Default Constructor
        /// </summary>
        static DBWrapper()
        {
            using (Log log = new Log("Glx.DB.DBWrapper::DBWrapper()"))
            {

                _sDBStringPath = "";
                _sDBConectionString = "";
                _SqlDataReader = null;
            }
           
        }

        /// <summary>
        /// RefreshReader
        /// </summary>
        private static void RefreshReader()
        {
            using (Log log = new Log("Glx.DB.DBWrapper::RefreshReader()"))
            {
                try
                {
                    if (null != _SqlDataReader)
                    {
                        if (!_SqlDataReader.IsClosed)
                        {
                            _SqlDataReader.Close();
                            _SqlDataReader = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }    
        }

        /// <summary>
        /// InitializeDB
        /// </summary>
        /// <param name="sFilePath_i"></param>
        /// <param name="bIsDependend_i"></param>
        public static void InitializeDB(string sFilePath_i, bool bIsDependend_i)
        {
            using (Log log = new Log("Glx.DB.DBWrapper::InitializeDB()"))
            {
                try
                {
                    _sDBConectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=";
                    if (bIsDependend_i)
                    {
                        _sDBStringPath = System.Environment.CurrentDirectory + sFilePath_i;
                    }
                    else
                    {
                        _sDBStringPath = sFilePath_i;
                    }
                    _sDBConectionString += _sDBStringPath;
                    _sDBConectionString += ";Integrated Security=True;Connect Timeout=30;User Instance=True";
                    ConnectDB();
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }   
        }

        /// <summary>
        /// ExecuteNonQueryEx
        /// </summary>
        /// <param name="sQuery_i"></param>
        /// <returns></returns>
        public static bool ExecuteNonQueryEx(string sQuery_i)
        {
            using (Log log = new Log("Glx.DB.DBWrapper::ExecuteNonQueryEx()"))
            {
                try
                {
                    RefreshReader();
                    if (null == sQuery_i)
                    {
                        return false;
                    }
                    SqlCommand sqlCommand = SetCommand(sQuery_i);
                    int nEffectedRows = 0;
                    nEffectedRows = sqlCommand.ExecuteNonQuery();
                    if (nEffectedRows > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// ExecuteQuery
        /// </summary>
        /// <param name="sQuery_i"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteQuery(string sQuery_i)
        {
            using (Log log = new Log("Glx.DB.DBWrapper::ExecuteQuery()"))
            {
                try
                {
                    RefreshReader();
                    if (null == sQuery_i)
                    {
                        return null;
                    }
                    SqlCommand sqlCommand = SetCommand(sQuery_i);
                    _SqlDataReader = sqlCommand.ExecuteReader();
                    return _SqlDataReader;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return null;
                }
            }    
        }

        /// <summary>
        /// GetSqlConnection
        /// </summary>
        private static SqlConnection GetSqlConnection
        {
            get
            {
                return _SqlConnection;
            }
        }

        /// <summary>
        /// ConnectDB()
        /// </summary>
        private static bool ConnectDB()
        {
            using (Log log = new Log("Glx.DB.DBWrapper::ConnectDB()"))
            {
                try
                {
                    _SqlConnection = new SqlConnection(_sDBConectionString);
                    if (_SqlConnection.State != ConnectionState.Open)
                    {
                        _SqlConnection.Open();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return false;
                }

            }
            
            return false;
        }

        /// <summary>
        /// DisConnectDB
        /// </summary>
        private static bool DisConnectDB()
        {
            using (Log log = new Log("Glx.DB.DBWrapper::DisConnectDB()"))
            {
                try
                {
                    if (_SqlConnection.State != ConnectionState.Closed)
                    {
                        _SqlConnection.Close();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return false;
                }
            }
            return false;
        }


        /// <summary>
        /// SetCommand
        /// </summary>
        /// <param name="csQuery"></param>
        /// <returns></returns>
        private static SqlCommand SetCommand(string csQuery)
        {
            using (Log log = new Log("Glx.DB.DBWrapper::SetCommand()"))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = csQuery;
                    sqlCommand.Connection = _SqlConnection;
                    return sqlCommand;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    return null;
                }
            }
        }
    }
}
