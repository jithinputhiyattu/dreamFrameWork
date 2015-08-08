/***
 * 
 * @Filename        :   AutoPanelG.cs
 * @Description     :   An automatic panel with a title and minimize button.The panel body can
 *	                    be minimized and maximized. The title is visible all the time.
 *	
 * 	                    Additional features
 *                   	
 *	                    1. Can be moved by clicking and dragging the title bar when not docked
 * 		                    2. Can switch between minimize and maximize state by
 *			                    a) Clicking minimize button on the right
 *			                    b) Double clicking the title bar
 *		                    3. As this is a panel, other user controls can be placed inside. 
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date		    :	2013/08/02/23:50
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
    /// AutoPanelG class
    /// </summary>
    public partial class AutoPanelG : Panel
    {
        private bool bMinimized = false;
        private eState _eState;
        private bool bMoveEnabled;
        private int nHeight_Static, nHeight;
        private string sCaption = "Caption";
        private eControlBoxPositions mControlBoxPosition = eControlBoxPositions.Top;

        private bool bDrag = false;
        private int nOldLocatonX;
        private int nOldLocatonY;

        private bool bStateSet = false;

        private Timer AnimationTimer;
        private int  nHeightChangeRate = 0;
        private int nAnimationSpeed = 10;

        /// <summary>
        /// Enum holding control box positions
        /// </summary>
        public enum eControlBoxPositions
		{
			Top,
			Bottom,
            //Left,
            //Right
		}

        /// <summary>
        /// Enum holding the states of the panel
        /// </summary>
        public enum eState
        {
            Minimized,
            Maximized,
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public AutoPanelG()
        {
            InitializeComponent();
            mControlBoxPosition = eControlBoxPositions.Top;
            nHeight = this.Height;
            nHeight_Static = nHeight;
            _eState = eState.Maximized;
            bMoveEnabled = true;

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
            int Height = this.Height + nHeightChangeRate;
            if (Height >= nHeight)
            {
                Height = nHeight;
                AnimationTimer.Enabled = false;

                if (nHeightChangeRate == nAnimationSpeed)
                    panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupOpen;
                else
                    panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupClose;
            }
            else if (Height <= panel_tittle.Height)
            {
                Height = panel_tittle.Height;
                AnimationTimer.Enabled = false;

                if (nHeightChangeRate == nAnimationSpeed)
                    panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupOpen;
                else
                    panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupClose;
            }
            this.Height = Height;
        }
        /// <summary>
        /// Property - control box position
        /// </summary>
        [Description("Set the postion of the control box"), Category("AutoPanelG")]
        public eControlBoxPositions ControlboxPosition
        {
            get
            {
                return mControlBoxPosition;

            }
            set
            {
                mControlBoxPosition = value;
                //SetControlBoxPosition();
            }
        }

        /// <summary>
        /// Property - Panel state
        /// </summary>
        [Description("Set the state of the panel, Maximized or Minimized"), Category("AutoPanelG")]
        private eState State
        {
            get
            {
                return _eState;

            }
            set
            {
                _eState = value;
                SetState();
            }
        }

        /// <summary>
        /// Property - Panel caption
        /// </summary>
        [Description("Set a caption"), Category("AutoPanelG")]
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
        /// SetControlBoxPosition
        /// </summary>
        private void SetControlBoxPosition()
        {
            switch (mControlBoxPosition)
            {
                case eControlBoxPositions.Top:
                    {
                        panel_tittle.Dock = DockStyle.Top;
                        panel_Pop.Dock = DockStyle.Right;
                        panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PanelUp;
                    }
                    break;
                case eControlBoxPositions.Bottom:
                    {
                        panel_tittle.Dock = DockStyle.Bottom;
                        panel_Pop.Dock = DockStyle.Right;
                        panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PanelUp;
                    }
                    break;
               /* case ControlBoxPositions.Left:
                    {
                        panel_tittle.Dock = DockStyle.Left;
                        panel_Pop.Dock = DockStyle.Left;
                        panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PanelLeft;
                    }
                    break;
                case ControlBoxPositions.Right:
                    {
                        panel_tittle.Dock = DockStyle.Right;
                        panel_Pop.Dock = DockStyle.Right;
                        panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PanelRight;
                    }
                    break;*/

            }
        }

        /// <summary>
        /// SetState
        /// </summary>
        private void SetState()
        {
            if (_eState == eState.Maximized)
            {
                this.Size = new Size(this.Width, nHeight);
                bMinimized = false;
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupOpen;

                //nHeight = this.Height;
            }
            else
            {
                //nHeight_Static = this.Height;
                this.Size = new Size(this.Width, panel_tittle.Height);
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupClose;
                bMinimized = true;
            }  
        }


       /* [Description("Panel state"), Category("PanelGex")]
        public bool Minimized
        {
            get
            {
                return bMinimized;
                
            }
            set
            {
                bMinimized = value;
                Minimize( );
            }

            
        }

        private void Minimize( )
        {
            if ( bMinimized )
            {
                this.Size = new Size(this.Width, nHeight );
                bMinimized = false;
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupOpen;
            }
            else
            {
                nHeight = this.Height;
                this.Size = new Size(this.Width, label_Caption.Height);
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupClose;
                bMinimized = true;
            }
        }
        */

        /// <summary>
        /// panel_Pop_Click - Switch between Minimized and Maximized states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Pop_Click(object sender, EventArgs e)
        {
            /*bMinimized = !bMinimized;

            if (!bMinimized)
            {
                this.Size = new Size(this.Width, nHeight);
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupOpen;
            }
            else
            {
                this.Size = new Size(this.Width, panel_tittle.Height);
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupClose;

            }*/
            if (!AnimationTimer.Enabled)
            {
                nHeightChangeRate = this.Height == panel_tittle.Height ? nAnimationSpeed : -nAnimationSpeed;
                if (nHeightChangeRate == -nAnimationSpeed) nHeight = this.Height;
                AnimationTimer.Enabled = true;
            }
           
            
        }

        /// <summary>
        /// AutoPanelG_Resize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoPanelG_Resize(object sender, EventArgs e)
        {
            // Save the new Height. Dont save when minimize operation is carried out. ie.
            // when minimizing, the height becomes panel_tittle.Height
           /* if (this.Height != panel_tittle.Height)
            {
                nHeight = this.Height;
                //nHeight_Static = nHeight;
            }*/
        }

        /// <summary>
        /// label_Caption_MouseMove - Move the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Caption_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMoveEnabled & bDrag && e.Button == MouseButtons.Left)
            {
                this.Left += (e.X - nOldLocatonX);
                this.Top += (e.Y - nOldLocatonY);
            }
            else
            {
                //this.Width += 1;
                //this.nHeight += 1;
            }
        }

        /// <summary>
        /// label_Caption_MouseUp - Stop panel movement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Caption_MouseUp(object sender, MouseEventArgs e)
        {
            bDrag = false;
        }

        /// <summary>
        /// label_Caption_MouseDown - Start move panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Caption_MouseDown(object sender, MouseEventArgs e)
        {
            bDrag = true;
            nOldLocatonX = e.X;
            nOldLocatonY = e.Y;
        }

        /// <summary>
        /// label_Caption_DoubleClick - Switch between maximized and minimized states by double clicking the titlebar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Caption_DoubleClick(object sender, EventArgs e)
        {
            /*if (bMinimized)
            {
                this.Size = new Size(this.Width, nHeight);
                bMinimized = false;
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupOpen;
            }
            else
            {
                //nHeight = this.Height;
                this.Size = new Size(this.Width, panel_tittle.Height);
                panel_Pop.BackgroundImage = Glx.Gui.Properties.Resources.PopupClose;
                bMinimized = true;
            }*/

            if (!AnimationTimer.Enabled)
            {
                nHeightChangeRate = this.Height == panel_tittle.Height ? nAnimationSpeed : -nAnimationSpeed;
                if (nHeightChangeRate == -nAnimationSpeed) nHeight = this.Height;
                AnimationTimer.Enabled = true;
            }
        }

        /// <summary>
        /// AutoPanelG_DockChanged - Do not perform move operation if the panel is docked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoPanelG_DockChanged(object sender, EventArgs e)
        {
            if (this.Dock != DockStyle.None)
                bMoveEnabled = false;
            else
                bMoveEnabled = true;
        }
    }
}
