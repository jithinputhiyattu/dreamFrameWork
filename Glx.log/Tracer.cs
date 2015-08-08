/***
 * 
 * @Filename        :   Tracer.cs
 * @Description     :   
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/07/25/11:56
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glx.Logger
{
    /// <summary>
    /// Tracer class - used by Log class
    /// </summary>
    public static class Tracer
    {
        private static string _sFileName;
        private static bool _bTraceFlag;
        private static bool _bErrorTraceFlag;
        private static long _lLogLimit;
        private static long LOG_LIMIT = 100000;
        public static int TraceDepth = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        static Tracer()
        {
            try
            {
                _bTraceFlag = true;
                _bErrorTraceFlag = true;
                _lLogLimit = 0;
                InitializeTracer();

            }
            catch (System.Exception exception_ex)
            {
            }
        }

        /// <summary>
        /// InitializeTracer
        /// </summary>
        public static void InitializeTracer()
        {
            try
            {
                System.IO.Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\logs\\");
                _sFileName = System.Environment.CurrentDirectory + "\\logs\\";

                _sFileName += System.DateTime.Now.ToLocalTime().ToLongDateString() + ", ";

                _sFileName += " " + System.DateTime.Now.Hour.ToString();
                _sFileName += " " + System.DateTime.Now.Minute.ToString();
                _sFileName += " " + System.DateTime.Now.Second.ToString()+ ".logx";
            }
            catch (System.Exception ex)
            {
            }
        }

        /// <summary>
        /// Property : TraceFlag
        /// </summary>
        public static bool TraceFlag
        {
            get
            {
                return _bTraceFlag;
            }
            set
            {
                if (value != _bTraceFlag)
                {
                    _bTraceFlag = value;
                }
            }
        }

        /// <summary>
        /// Property : ErrorTraceFlag
        /// </summary>
        public static bool ErrorTraceFlag
        {
            get
            {
                return _bErrorTraceFlag;
            }
            set
            {
                if (value != _bErrorTraceFlag)
                {
                    _bErrorTraceFlag = value;
                }
            }
        }

        /// <summary>
        /// Get current time
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            string sTimeStamp = null;
            try
            {
                //sTimeStamp = "\n" + DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString() + " " + System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString() + ":" + System.DateTime.Now.Millisecond.ToString() + "    ";
                sTimeStamp =  DateTime.Now + " ";
            }
            catch (System.Exception ex)
            {
            }
            return sTimeStamp;
        }

        /// <summary>
        /// Write trace info
        /// </summary>
        /// <param name="sInfo_i"></param>
        /// <param name="sTabs"></param>
        public static void Trace(string sInfo_i, string sTabs )
        {
            try
            {
                TraceDepth++;
                if (TraceFlag)
                {
                    System.IO.File.AppendAllText(_sFileName, "\n" + sTabs +  GetTimeStamp()  + sInfo_i);
                    RefreshEx();
                }
            }
            catch (System.Exception ex)
            {
            }
        }

        /// <summary>
        /// Write a string to log file
        /// </summary>
        /// <param name="sInfo_i"></param>
        /// <param name="sTabs"></param>
        public static void PutS(string sInfo_i, string sTabs)
        {
            try
            {
                if (TraceFlag)
                {
                    System.IO.File.AppendAllText(_sFileName, "\n" + sTabs +  sInfo_i);
                    RefreshEx();
                }
            }
            catch (System.Exception ex)
            {
            }
        }

        /// <summary>
        /// Write a Querry string to log file
        /// </summary>
        /// <param name="sInfo_i"></param>
        /// <param name="sTabs"></param>
        public static void PutQuerry(string sInfo_i, string sTabs)
        {
            try
            {
                if (TraceFlag)
                {
                    System.IO.File.AppendAllText(_sFileName, "\n" + sTabs + "Querry executed:\n" + sTabs +  sInfo_i);
                    RefreshEx();
                }
            }
            catch (System.Exception ex)
            {
            }
        }

        /// <summary>
        /// Write 
        /// </summary>
        /// <param name="sInfo_i"></param>
        public static void EndTrace(string sInfo_i, string sTabs)
        {
            try
            {
                if (TraceFlag)
                {
                    System.IO.File.AppendAllText(_sFileName, "\n" + sTabs + "}//" + sInfo_i + "\n");
                    RefreshEx();
                }
            }
            catch (System.Exception ex)
            {
            }
        }
        /// <summary>
        /// Exception
        /// </summary>
        /// <param name="sError_i"></param>
        public static void Exception( Exception exeption, string sMethodName, string sTabs)
        {
            try
            {
                if (ErrorTraceFlag)
                {
                    //System.IO.File.AppendAllText(_sFileName, "\n" + sTabs + GetTimeStamp() + _sErrorPrifix + sError_i +"\n" + sTabs + ex.Message + "\n" + sTabs + ex.StackTrace +"\n" + sTabs + ex.ToString());
                    System.IO.File.AppendAllText(_sFileName, "\n" + sTabs + GetTimeStamp() + ", Error in " + "\n" + sTabs + sMethodName + "\n" + sTabs + "ERROR: " + exeption.Message + "\n"); 
                    RefreshEx();
                }
            }
            catch (System.Exception ex)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static void RefreshEx()
        {
            try
            {
                _lLogLimit++;
                if (_lLogLimit > LOG_LIMIT)
                {
                    InitializeTracer();
                    _lLogLimit = 0;
                }
            }
            catch (System.Exception ex)
            {
            }
        }
    }
}