/***
 * 
 * @Filename        :   ToolTipG.cs
 * @Description     :   Custom Tooltip
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/03/14:42
 *
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Glx.Gui
{
    /// <summary>
    /// ToolTipG class
    /// </summary>
   public class ToolTipG : ToolTip
   {
       /// <summary>
       /// Constructor
       /// </summary>
        public ToolTipG()
        {
            this.OwnerDraw = true;
            this.Draw += new DrawToolTipEventHandler(OnDraw);
        }
    
       /// <summary>
       /// Constructor
       /// </summary>
       /// <param name="Cont"></param>
       public ToolTipG(System.ComponentModel.IContainer Cont)
       {
             this.OwnerDraw = true;
             this.Draw += new DrawToolTipEventHandler(OnDraw);
       }

       /// <summary>
       /// OnDraw event
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void OnDraw(object sender, DrawToolTipEventArgs e)
       {  
           /* DrawToolTipEventArgs newArgs = new DrawToolTipEventArgs(e.Graphics,
            e.AssociatedWindow, e.AssociatedControl, e.Bounds, e.ToolTipText,
            Color.DarkRed, Color.White, new Font("Arial Unicode MS", 8.25f, FontStyle.Bold));
           
            newArgs.DrawBackground();

            newArgs.DrawBorder();

            newArgs.DrawText(TextFormatFlags.TextBoxControl);*/

            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
       }

    }

   /// <summary>
   /// Error Tooltip class
   /// </summary>
   public class ErrorToolTipG : ToolTipG
   {
       /// <summary>
       /// Constructor 
       /// </summary>
       public ErrorToolTipG()
       {
           ForeColor = Color.White;
           BackColor = Color.DarkRed;
       }
      

   }

   /// <summary>
   /// Error Tooltip class
   /// </summary>
   public class InfoToolTipG : ToolTipG
   {
       /// <summary>
       /// Constructor 
       /// </summary>
       public InfoToolTipG()
       {
           ForeColor = Color.Black;
           BackColor = Color.DarkGray;
       }


   }
}
