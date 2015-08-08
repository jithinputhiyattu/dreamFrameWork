/***
 * 
 * @Filename        :   Evaluator.cs
 * @Description     :   Evaluate an expression
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/1:00
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.JScript;


namespace Glx.Common.Evaluator
{
    /// <summary>
    /// Evaluator class
    /// </summary>
    public class EvalG
    {
        /// <summary>
        /// Evaluate expression and return integer value
        /// </summary>
        /// <param name="sExpression"></param>
        /// <returns></returns>
        public static int EvalToInteger(string sExpression)
        {
            string s = EvalToString(sExpression);
            return int.Parse(s.ToString());
        }

        /// <summary>
        /// Evaluate expression and return double value
        /// </summary>
        /// <param name="sExpression"></param>
        /// <returns></returns>
        public static double EvalToDouble(string sExpression)
        {
            string s = EvalToString(sExpression);
            return double.Parse(s);
        }

        /// <summary>
        /// Evaluate expression and return string equivalent of value
        /// </summary>
        /// <param name="sExpression"></param>
        /// <returns></returns>
        public static string EvalToString(string sExpression)
        {
            object o = EvalToObject(sExpression);
            return o.ToString();
        }

        /// <summary>
        /// Evaluate expression and return value as object
        /// </summary>
        /// <param name="sExpression"></param>
        /// <returns></returns>
        public static object EvalToObject(string sExpression)
        {
            return _evaluatorType.InvokeMember(
                        "Eval",
                        BindingFlags.InvokeMethod,
                        null,
                        _evaluator,
                        new object[] { sExpression }
                     );
        }

        /// <summary>
        /// Evaluator
        /// </summary>
        static EvalG()
        {
            ICodeCompiler compiler;
            compiler = new JScriptCodeProvider().CreateCompiler();

            CompilerParameters parameters;
            parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;

            CompilerResults results;
            results = compiler.CompileAssemblyFromSource(parameters, _jscriptSource);

            Assembly assembly = results.CompiledAssembly;
            _evaluatorType = assembly.GetType("Evaluator.Evaluator");

            _evaluator = Activator.CreateInstance(_evaluatorType);
        }

        private static object _evaluator = null;
        private static Type _evaluatorType = null;
        private static readonly string _jscriptSource =

            @"package Evaluator
            {
               class Evaluator
               {
                  public function Eval(expr : String) : String 
                  { 
                     return eval(expr); 
                  }
               }
            }";
    }

}
