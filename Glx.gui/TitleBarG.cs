/***
 * 
 * @Filename        :   TitleBarG.cs
 * @Description     :   GUI definition
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/01/23:41
 *
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glx.Gui
{
    /// <summary>
    /// TitleBarG
    /// </summary>
    public partial class TitleBarG : UserControl
    {
        private bool _bCanFormMove;                    
        private int _nOldLocatonX;
        private int _nOldLocatonY;
        private bool _nPopupState = false;
        private eCloseButtonAction _CloseButtonAction;
        private string _sTitle;

        public enum eCloseButtonAction
        {
            Close,
            Exit,
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public TitleBarG()
        {
            InitializeComponent();
            _CloseButtonAction = eCloseButtonAction.Close;
        }

        /// <summary>
        /// Property to set close button action - Close or Exit
        /// </summary>
        public eCloseButtonAction CloseButtonAction
        {
            get
            {
                return _CloseButtonAction;

            }
            set
            {
                _CloseButtonAction = value;
            }
        }

        /// <summary>
        /// Property : Title
        /// </summary>
        public string Title
        {
            get
            {
                return _sTitle;

            }
            set
            {
                _sTitle = value;
                label_Form_Name.Text = _sTitle;
            }
        }

        /// <summary>
        /// Mousedown event to start the form move
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
        /// Mousemove event to move the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void panel_TitleBar_MouseMove(object sender, MouseEventArgs eventArgs)
        {
            if (_bCanFormMove)
            {
                ParentForm.Left += (eventArgs.X - _nOldLocatonX);
                ParentForm.Top += (eventArgs.Y - _nOldLocatonY);
            }
        }

        /// <summary>
        /// Mouseup event for end the form move 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void panel_TitleBar_MouseUp(object sender, MouseEventArgs eventArgs)
        {
            _bCanFormMove = false;
        }

        /// <summary>
        /// Maximize|Restore button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Maximize_Click(object sender, EventArgs e)
        {
            if ( ParentForm.WindowState == FormWindowState.Maximized)
            {
                // Restore or normal state
                ParentForm.WindowState = FormWindowState.Normal;
                panel_Maximize.BackgroundImage = global::Glx.Gui.Properties.Resources.Maximize;
                panel_Control_Box.Padding = new Padding(0, 0, 0, 0);
            }
            else
            {
                // maximized state
                ParentForm.WindowState = FormWindowState.Maximized;
                panel_Maximize.BackgroundImage = global::Glx.Gui.Properties.Resources.Restore;
                panel_Control_Box.Padding = new Padding(0, 0, 4, 0);
            }
        }

        /// <summary>
        /// Minimize button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Minimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Close button click event. Close parent form or Exit Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Close_Click(object sender, EventArgs e)
        {
            if (_CloseButtonAction == eCloseButtonAction.Close)
                ParentForm.Close();
            else 
                Application.Exit();
        }

        /// <summary>
        /// panel_Minimize_MouseHover to change the black icon to blue icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Minimize_MouseHover(object sender, EventArgs e)
        {
            panel_Minimize.BackgroundImage = Glx.Gui.Properties.Resources.Minimize_Hower;
        }

        /// <summary>
        /// panel_Minimize_MouseLeave to change the blue icon to black icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Minimize_MouseLeave(object sender, EventArgs e)
        {
            panel_Minimize.BackgroundImage = Glx.Gui.Properties.Resources.Minimize;
        }

        /// <summary>
        /// panel_Maximize_MouseLeave to change the blue icon to black icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Maximize_MouseLeave(object sender, EventArgs e)
        {
            if ( ParentForm.WindowState == FormWindowState.Maximized)
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Restore;
            else
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Maximize;
        }

        /// <summary>
        /// panel_Maximize_MouseHover to change the black icon to blue icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Maximize_MouseHover(object sender, EventArgs e)
        {
            if (ParentForm.WindowState == FormWindowState.Maximized)
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Restore_Hower;
            else
                panel_Maximize.BackgroundImage = Glx.Gui.Properties.Resources.Maximize_Hower;

        }

        /// <summary>
        /// panel_Close_MouseHover to change the black icon to blue icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Close_MouseHover(object sender, EventArgs e)
        {
            panel_Close.BackgroundImage = Glx.Gui.Properties.Resources.Close_Hower;
        }

        /// <summary>
        /// panel_Close_MouseLeave to change the blue icon to black icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Close_MouseLeave(object sender, EventArgs e)
        {
            panel_Close.BackgroundImage = Glx.Gui.Properties.Resources.Close;
        }

        /// <summary>
        /// label_Form_Name_MouseMove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseMove(object sender, MouseEventArgs e)
        {
            panel_TitleBar_MouseMove(sender, e);
        }

        /// <summary>
        /// label_Form_Name_MouseUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseUp(object sender, MouseEventArgs e)
        {
            panel_TitleBar_MouseUp(sender, e);
        }

        /// <summary>
        /// label_Form_Name_MouseDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseDown(object sender, MouseEventArgs e)
        {
            panel_TitleBar_MouseDown(sender, e);
        }

        /// <summary>
        /// panel_TitleBar_MouseDoubleClick event which maximized the window on double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel_Maximize_Click(sender, e);
        }

        /// <summary>
        ///  label_Form_Name_MouseDoubleClick event which maximized the window on double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Form_Name_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel_Maximize_Click(sender, e);
        }


    }
}
