/***
 * 
 * @Filename        :   SidePanelG.cs
 * @Description     :   An automatic panel with a minimize button.The panel body can
 *                      be minimized and maximized. 
 *	
 *	                    Additional features
 *		                    1. As this is a panel, other user controls can be placed inside.
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/02/6:23
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
    /// Side panel class
    /// </summary>
    public partial class SidePanelG : Panel
    {
        private bool bOpen;         
        private int nWidth;
        private int nMinimizedWidth;

        private Timer AnimationTimer;
        private int nWidthChangeRate = 0;
        private int nAnimationSpeed = 10;
        /// <summary>
        /// Constructor
        /// </summary>
        public SidePanelG()
        {
            InitializeComponent();
            bOpen = true;
            nWidth = this.Width;
            nMinimizedWidth = panel_SideBar.Width + 2;

            AnimationTimer = new Timer();
            AnimationTimer.Interval = 16;
            AnimationTimer.Tick += new EventHandler(AnimationTimer_Tick);   
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
        /// AnimationTimer_Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int Width = this.Width + nWidthChangeRate;
            if (Width >= nWidth)
            {
                Width = nWidth;
                AnimationTimer.Enabled = false;

                if (nWidthChangeRate != nAnimationSpeed)
                    panel_SideBar.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
                else
                    panel_SideBar.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
            }
            else if (Width <= nMinimizedWidth)
            {
                Width = nMinimizedWidth;
                AnimationTimer.Enabled = false;

                if (nWidthChangeRate != nAnimationSpeed)
                    panel_SideBar.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
                else
                    panel_SideBar.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
            }
            this.Width = Width;
        }

        /// <summary>
        /// Open & Close side panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Sidebar_Click(object sender, EventArgs e)
        {
            /*bOpen = !bOpen;

            if (!bOpen)
            {
                this.Width = nMinimizedWidth;
                panel_SideBar.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
            }
            else
            {
                this.Width = nWidth;
                panel_SideBar.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
                
            }*/
            if (!AnimationTimer.Enabled)
            {
                nWidthChangeRate = this.Width == nMinimizedWidth ? nAnimationSpeed : -nAnimationSpeed;
                if (nWidthChangeRate == -nAnimationSpeed) nWidth = this.Width;
                AnimationTimer.Enabled = true;
            }

        }

        /// <summary>
        /// Set width to new width after resizing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SidePanelG_Resize(object sender, EventArgs e)
        {
            /*if (this.Width != nMinimizedWidth )
            {
                nWidth = this.Width;
            }*/
        }

    }
}
