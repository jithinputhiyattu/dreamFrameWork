/***
 * 
 * @Filename        :   FormGEx.cs
 * @Description     :   
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/02/6:36
 *
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glx.Gui
{
    /// <summary>
    /// FormG class
    /// </summary>
    public partial class FormGEx : Form
    {
        private bool _bCanFormMove;
        private int _nOldLocatonX;
        private int _nOldLocatonY;
        private bool _nPopupState = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormGEx()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn_Minimize_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// btn_Close_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// panel_TitleBar_MouseDown - start form move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void panel_TitleBar_MouseDown(object sender, MouseEventArgs eventArgs)
        {
            if (eventArgs.Button == MouseButtons.Left)
            {
                _bCanFormMove = true;
                _nOldLocatonX = eventArgs.X;
                _nOldLocatonY = eventArgs.Y;
            }
        }

        /// <summary>
        /// panel_TitleBar_MouseMove - move form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void panel_TitleBar_MouseMove(object sender, MouseEventArgs eventArgs)
        {
            if (_bCanFormMove)
            {
                this.Left += (eventArgs.X - _nOldLocatonX);
                this.Top += (eventArgs.Y - _nOldLocatonY);
            }
        }

        /// <summary>
        /// panel_TitleBar_MouseUp - end form move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void panel_TitleBar_MouseUp(object sender, MouseEventArgs eventArgs)
        {
            _bCanFormMove = false;
        }

        /// <summary>
        /// panel_Maximize_Click - Maximize and restore operations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                panel_Maximize.BackgroundImage = global::Glx.Gui.Properties.Resources.Maximize;
                panel_Control_Box.Padding = new Padding(0, 0, 0, 0);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                panel_Maximize.BackgroundImage = global::Glx.Gui.Properties.Resources.Restore;
                panel_Control_Box.Padding = new Padding(0, 0, 4, 0);
            }
        }

        /// <summary>
        /// panel_Minimize_Click - minimize operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// panel_Close_Click - Close operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// panel_Minimize_MouseHover - Highlight Minimize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Minimize_MouseHover(object sender, EventArgs e)
        {
            panel_Minimize.BackgroundImage = Glx.Gui.Properties.Resources.Minimize_Hower;
        }

        /// <summary>
        /// panel_Minimize_MouseLeave - De highlight Minimize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Minimize_MouseLeave(object sender, EventArgs e)
        {
            panel_Minimize.BackgroundImage = Glx.Gui.Properties.Resources.Minimize;
        }

        /// <summary>
        /// panel_Maximize_MouseLeave - De highlight maximize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Maximize_MouseLeave(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Restore;
            else
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Maximize;
        }

        /// <summary>
        /// panel_Maximize_MouseHover - highlight maximize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Maximize_MouseHover(object sender, EventArgs e)
        {
            if( WindowState == FormWindowState.Maximized )
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Restore_Hower;
            else
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Maximize_Hower;
                
        }

        /// <summary>
        /// panel_Close_MouseHover - Highlight Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Close_MouseHover(object sender, EventArgs e)
        {
            panel_Close.BackgroundImage = Glx.Gui.Properties.Resources.Close_Hower;
        }

        /// <summary>
        /// panel_Close_MouseLeave - De highlight Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Close_MouseLeave(object sender, EventArgs e)
        {
            panel_Close.BackgroundImage = Glx.Gui.Properties.Resources.Close;
        }

        /// <summary>
        /// label_Form_Name_MouseMove - form move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseMove(object sender, MouseEventArgs e)
        {
            panel_TitleBar_MouseMove( sender, e);
        }

        /// <summary>
        /// label_Form_Name_MouseUp - End form move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseUp(object sender, MouseEventArgs e)
        {
            panel_TitleBar_MouseUp(sender, e);
        }

        /// <summary>
        /// label_Form_Name_MouseDown - Start form move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseDown(object sender, MouseEventArgs e)
        {
            panel_TitleBar_MouseDown(sender, e);
        }

        /// <summary>
        /// panel_TitleBar_MouseDoubleClick - Maximize by double clicking the title bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel_Maximize_Click(sender, e);
        }

        /// <summary>
        /// label_Form_Name_MouseDoubleClick - Maximize by double clicking the title bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel_Maximize_Click(sender, e);
        }

       /* private void panel1_Click(object sender, EventArgs e)
        {
            if (_nPopupState)
            {
                //for (int i = panel_Popup.Location.Y; i >= 27; i -= 1)
                {
                    panel_Popup.Size = new Size(panel_Popup.Size.Width, panel_Popup.Size.Height - 100);
                }
            }
            else
            {
                //for (int i = panel_Popup.Location.Y; i <= 150; i += 1)
                {
                    panel_Popup.Size = new Size(panel_Popup.Size.Width, panel_Popup.Size.Height + 100);
                }
            }

            _nPopupState = !_nPopupState;

        }*/
    }
}
