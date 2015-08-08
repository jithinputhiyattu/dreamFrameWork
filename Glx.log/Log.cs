/***
 * 
 * @Filename        :   Log.cs
 * @Description     :   
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/07/25/11:53
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glx.Gui;
using System.Windows.Forms;

namespace Glx.Logger
{
    /// <summary>
    /// logger class
    /// </summary>
    public class Log : IDisposable
    {
        private string _sClassFunctionName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sClassFunctionName_i"></param>
        public Log(string sClassFunctionName_i)
        {
            _sClassFunctionName = sClassFunctionName_i;

            string sTabs = "";

            for( int i = 0; i < Tracer.TraceDepth; i++ )
                sTabs += "\t";

            Tracer.Trace( "\n" + sTabs + _sClassFunctionName + "\n" + sTabs + "{",sTabs);
        }

        /// <summary>
        /// Write error
        /// </summary>
        /// <param name="ex"></param>
        public void Error(Exception ex)
        {
            string sTabs = "\n";

            for (int i = 0; i < Tracer.TraceDepth; i++)
                sTabs += "\t";

            Tracer.Exception( ex, _sClassFunctionName, sTabs);
        }

        /// <summary>
        /// Write error and display message
        /// </summary>
        /// <param name="ex"></param>
        public void ErrorEx(Exception ex)
        {
            string sTabs = "\n";

            for (int i = 0; i < Tracer.TraceDepth; i++)
                sTabs += "\t";

            Tracer.Exception(ex, _sClassFunctionName, sTabs);
            GuiG.MsgBox("Error in " + _sClassFunctionName + " Error: " + ex.Message, "Error", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Writes a string to log file
        /// </summary>
        /// <param name="sInfo"></param>
        public void PutS(string sInfo)
        {
            string sTabs = "";

            for (int i = 0; i < Tracer.TraceDepth; i++)
                sTabs += "\t";

            Tracer.PutS(sInfo, sTabs);
        }

        /// <summary>
        /// Writes a Querry string to log file
        /// </summary>
        /// <param name="sInfo"></param>
        public void PutQuerry(string sInfo)
        {
            string sTabs = "";

            for (int i = 0; i < Tracer.TraceDepth; i++)
                sTabs += "\t";

            Tracer.PutQuerry(sInfo, sTabs);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            string sTabs = "";
            Tracer.TraceDepth--;

            for (int i = 0; i < Tracer.TraceDepth; i++)
                sTabs += "\t";

            Tracer.EndTrace(  _sClassFunctionName, sTabs ) ;
        }

    }
}
