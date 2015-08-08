/***
 * 
 * @Filename        :   Table.cs
 * @Description     :   Table class used represent a table, for easily performing CREATE, INSERT etc
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/0:02
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
    /// table class
    /// </summary>
    public class Table
    {
        private string sColumns;
        private string[] Columns;
        private int nColumnCount;

        /// <summary>
        /// Constructor : creates string array from entered string
        /// Working: Converts "Column1,Column2,Column3" to string[3]
        /// </summary>
        /// <param name="Columns_i"></param>
        public Table( string Columns_i )
        {   
            using (Log log = new Log("Glx.DB.Table::Table()"))
            {
            	try
            	{
                    sColumns = Columns_i;
                    Columns = Strings.Split(Columns_i, ",", -1, CompareMethod.Text);
                    nColumnCount = Columns.Length;  
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
            	}
            }
            
            
        }

        /// <summary>
        /// return the index of a column 
        /// </summary>
        /// <param name="Column"></param>
        /// <returns></returns>
        public int IndexOf(string Column)
        {
            using (Log log = new Log("Glx.DB.Table::IndexOf()"))
            {
            	try
            	{
                    for (int nIndex = 0; nIndex < nColumnCount; nIndex++)
                    {
                        if (String.Compare(Column, Columns[nIndex], true) == 0)
                            return nIndex;
                    }

            	}
            	catch (Exception ex)
            	{
                    log.Error(ex);
                    return -1;
            	}
            }
            
            
            return -1;
        }

        /// <summary>
        /// Returns the index of a column by the statement: TableObject/"column_name"
        /// </summary>
        /// <param name="t"></param>
        /// <param name="sColumn"></param>
        /// <returns></returns>
        public static int operator /( Table t, string sColumn )
        {
            using (Log log = new Log("Glx.DB.Table::/()"))
            {
            	try
            	{
                    for (int nIndex = 0; nIndex < t.nColumnCount; nIndex++)
                        if (String.Compare(sColumn, t.Columns[nIndex], true) == 0)
                            return nIndex;
            	}
            	catch (Exception ex)
            	{
            		log.Error(ex);
                    return -1;
            	}
            }

            return -1;
        }

    }
}
