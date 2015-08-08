/***
 * 
 * @Filename        :   DDL.cs
 * @Description     :   Data Definition Language - Functions for CREATE, INSERT etc.
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/0:03
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Glx.Logger;

namespace Glx.DB
{
    /// <summary>
    /// DDL class
    /// </summary>
    public static class DDL
    {
        /// <summary>
        /// Create a table 
        /// e.g. DDL.CreateTable( "Sample", "col1,int,col2,int,col3,varchar(10),col4,int,col5,int");
        /// </summary>
        /// <param name="sTableName"></param> - Name of the new table
        /// <param name="sColumns_i"></param> - A string containing list of colums in the format Column1,datatype,
        ///                                     Column2,datatype...etc
        public static void CreateTable(string sTableName, string sColumns_i)
        {
            using (Log log = new Log(".::()"))
            {
                try
                {

                    string sQuerry = "CREATE TABLE " + sTableName + "(";
                    string[] sColums = Strings.Split(sColumns_i, ",", -1, CompareMethod.Text);

                    sQuerry = sQuerry + sColums[0] + " " + sColums[1];

                    for (int nIndex = 2; nIndex < sColums.Length; nIndex += 2)
                        sQuerry = sQuerry + "," + sColums[nIndex] + " " + sColums[nIndex + 1];

                    sQuerry += ")";

                    DBWrapper.ExecuteNonQueryEx(sQuerry);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
      

        }

        /// <summary>
        /// Insert data into table
        /// e.g. DDL.InsertInto("Sample", "col1,col2", "10,20");
        /// </summary>
        /// <param name="sTableName"></param>
        /// <param name="sColumns_i"></param>
        /// <param name="sValues_i"></param>
        public static void InsertInto(string sTableName, string sColumns_i, string sValues_i )
        {
            using( Log log = new Log( "Glx.DB.DDL.InsertInto()" ) )
            {
                try
                {
                    string sQuerry = "INSERT INTO " + sTableName + "(";
                    string[] sColums = Strings.Split(sColumns_i, ",", -1, CompareMethod.Text);

                    sQuerry = sQuerry + sColums[0];

                    for (int nIndex = 1; nIndex < sColums.Length; nIndex++)
                        sQuerry = sQuerry + "," + sColums[nIndex];

                    sQuerry += ") VALUES(";

                    string[] sValues = Strings.Split(sValues_i, ",", -1, CompareMethod.Text);

                    sQuerry = sQuerry + sValues[0];

                    for (int nIndex = 1; nIndex < sValues.Length; nIndex++)
                        sQuerry = sQuerry + "," + sValues[nIndex];

                    sQuerry += ")";

                    log.PutQuerry( sQuerry);
                    DBWrapper.ExecuteNonQueryEx(sQuerry);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
        }

    }
}
