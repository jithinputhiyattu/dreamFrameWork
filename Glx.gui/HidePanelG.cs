/***
 * 
 * @Filename        :   HidePanelG.cs
 * @Description     :   A simple control with a toggle button and a label. 
 *                      Attach a panel to the 'AttachedPanel' property, and toggle
 *	                    between its Visible and Invisible states.
 *	                    
 *	                    Additional features
 *		                    1. Set visibility of attached panel on startup by setting 
 *                             'ShowAttachedPanel' property
 * 
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/02/6:32
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
    public partial class HidePanelG : UserControl
    {
        private Panel _AttachedPanel;
        private bool _bShowControl;
        private string sCaption = "Caption";
        private int nWidth;
        private int nMinimizedWidth = 0;

        private Timer AnimationTimer;
        private int nWidthChangeRate = 0;
        private int nAnimationSpeed = 30;

        public HidePanelG()
        {
            InitializeComponent();
            _bShowControl = false;
            _AttachedPanel = panel_Title;

            AnimationTimer = new Timer();
            AnimationTimer.Interval = 16;
            AnimationTimer.Tick += new EventHandler(AnimationTimer_Tick);   
        }

        public Panel AttachedPanel
        {
            get
            {
                return _AttachedPanel;
            }
            set
            {
                _AttachedPanel = value;
            }
        }

        public bool ShowAttachedPanel
        {
            get
            {
                return _bShowControl;
            }
            set
            {

                if (!AnimationTimer.Enabled)
                {
                    _bShowControl = value;
                    //ShowHideControl();
                }
            }
        }

        public string Caption
        {
            get
            {
                return sCaption;

            }
            set
            {
                sCaption = value;
                label_Caption.Text = value;
            }
        }

        /// <summary>
        /// Property - Speed of animation
        /// </summary>
        public int AnimationSpeed
        {
            get
            {
                return nAnimationSpeed;

            }
            set
            {
                nAnimationSpeed = value;
            }
        }

        /// <summary>
        /// WidthAnimationTimer_Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int Width = _AttachedPanel.Width + nWidthChangeRate;
            if (Width >= nWidth)
            {
                Width = nWidth;
                AnimationTimer.Enabled = false;
                if (nWidthChangeRate != nAnimationSpeed)
                    panel_Button.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
                else
                    panel_Button.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
            }
            else if (Width < Math.Abs(nWidthChangeRate))
            {
                Width = 0;
                AnimationTimer.Enabled = false;
                _AttachedPanel.Visible = false;
                if (nWidthChangeRate != nAnimationSpeed)
                    panel_Button.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
                else
                    panel_Button.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
            }
            _AttachedPanel.Width = Width;
        }


        private void ShowHideControl()
        {
           /* if (_bShowControl)
            {
                _AttachedPanel.Visible = true;
                _AttachedPanel.Width = nWidth;
                panel_Button.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
            }
            else
            {
                _AttachedPanel.Visible = false;
                _AttachedPanel.Width = 0;
                panel_Button.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
            }*/
  
            if (!AnimationTimer.Enabled)
            {
                nWidthChangeRate = _AttachedPanel.Width == nMinimizedWidth || !_AttachedPanel.Visible ? nAnimationSpeed : -nAnimationSpeed;
                if (nWidthChangeRate == -nAnimationSpeed)
                    nWidth = _AttachedPanel.Width;
                else
                    _AttachedPanel.Visible = true;

                AnimationTimer.Enabled = true;
            }

        }

        private void panel_Button_Click(object sender, EventArgs e)
        {
            //_bShowControl = !_bShowControl;

            if (!AnimationTimer.Enabled)
            {
                nWidthChangeRate = _AttachedPanel.Width == nMinimizedWidth || !_AttachedPanel.Visible ? nAnimationSpeed : -nAnimationSpeed;
                if (nWidthChangeRate == -nAnimationSpeed)
                    nWidth = _AttachedPanel.Width;
                else
                    _AttachedPanel.Visible = true;

                AnimationTimer.Enabled = true;
            }
        }
    }
}
