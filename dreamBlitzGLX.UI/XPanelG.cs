using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.Threading;



namespace dreamBlitzGLX.UI
{
    public class XPanelG : Panel
    {
        /// <summary>
        /// DisplayStatusE
        /// </summary>
        public enum DisplayStatusE
        {
            Show = 0,
            Hide,
        };

        Panel _TopPanel;
        ColorButton _ShowHideButton;
        DisplayStatusE _DisplayStatus;
        Label _CaptionPanel;
        int ControlHeight;
        const int SLEEP_TIME = 2;
        const int INCRIMENT_BY = 2;

        /// <summary>
        /// Constructor
        /// </summary>
        public XPanelG()
        {
            ControlHeight = 0;
            InitializeComponentsG();
        }
        /// <summary>
        /// InitializeComponentsG
        /// </summary>
        private void InitializeComponentsG()
        {
            _DisplayStatus = DisplayStatusE.Show;
            _TopPanel = new Panel();
            _ShowHideButton = new ColorButton();
            _ShowHideButton.Text = "#";
            _ShowHideButton.ButtonStyle = ColorButton.ButtonStyles.Ellipse;
            _CaptionPanel = new Label();
            _TopPanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            _CaptionPanel.Font = new Font("Arial", 12.75F);
            _CaptionPanel.Text = "XPanel";
            _CaptionPanel.Dock = DockStyle.Fill;
            _ShowHideButton.Click += new EventHandler(showHideButton_Click);
            _ShowHideButton.Width = 50;
            _ShowHideButton.Dock = DockStyle.Right;
            _TopPanel.Controls.Add(_ShowHideButton);
            _TopPanel.Controls.Add(_CaptionPanel);
            _TopPanel.Height = 50;
            _TopPanel.Dock = DockStyle.Top;
            this.Controls.Add(_TopPanel);
        }

        public string HeadingText
        {
            get{
                return _CaptionPanel.Text ;
            }
            set{
                if (value != _CaptionPanel.Text)
                {
                    _CaptionPanel.Text = value;
                }
            }
        }


        /// <summary>
        /// showHideButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showHideButton_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(ShowHideControls);
        }
        /// <summary>
        /// InvolkShoHideThread
        /// </summary>
        public void InvolkShoHideThread()
        {
            ThreadPool.QueueUserWorkItem(ShowHideControls);
        }
        /// <summary>
        /// ShowHideControls
        /// </summary>
        /// <param name="sender"></param>
        private void ShowHideControls(object sender)
        {
            if (DisplayStatusE.Show == _DisplayStatus)
            {
                if (0 == ControlHeight)
                {
                    ControlHeight = this.Height;
                }
                while (this.Height >= _TopPanel.Height)
                {
                    this.Invoke(new Action(delegate()
                    {
                        this.Height -= INCRIMENT_BY;
                    }));
                    Thread.Sleep(SLEEP_TIME);
                }
                this.Invoke(new Action(delegate()
                {
                    this.Height = _TopPanel.Height;
                }));
                _DisplayStatus = DisplayStatusE.Hide;
            }
            else
            {
                while (this.Height <= ControlHeight)
                {
                    this.Invoke(new Action(delegate()
                    {
                        this.Height += INCRIMENT_BY;
                    }));
                    Thread.Sleep(SLEEP_TIME);
                }
                this.Invoke(new Action(delegate()
               {
                   this.Height = ControlHeight;
               }));
                _DisplayStatus = DisplayStatusE.Show;
            }
        }
        /// <summary>
        /// DisplayStatus
        /// </summary>
        public DisplayStatusE DisplayStatus
        {
            get
            {
                return _DisplayStatus;
            }
            set
            {
                if (value != _DisplayStatus)
                {
                    _DisplayStatus = value;
                    InvolkShoHideThread();
                }
            }
        }
        /// <summary>
        /// Dock
        /// </summary>
        public override DockStyle Dock
        {
            get
            {
                return base.Dock;
            }
            set
            {
                if ((value != base.Dock) && ((value == DockStyle.Top) || (value == DockStyle.None)))
                {
                    base.Dock = value;
                }
            }
        }
    }
}
 