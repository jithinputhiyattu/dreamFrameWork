using System;

using System.Linq;

using System.Text;

using System.Collections.Generic;

using System.ComponentModel;

using System.Drawing;

using System.Drawing.Drawing2D;

using System.Windows.Forms;

namespace dreamBlitzGLX.UI
{
    public class GelButton : Button
    {



        #region Fields

        /// <summary>
        /// Colors
        /// </summary>
        private Color gradientTop = Color.FromArgb(255, 44, 85, 177);
        private Color gradientBottom = Color.FromArgb(255, 153, 198, 241);
        private Color paintGradientTop;
        private Color paintGradientBottom;
        private Color paintForeColor;

        private Rectangle buttonRect;
        private Rectangle highlightRect;

        private float rectOutlineWidth;

        private int highlightRectOffset;
        private int rectCornerRadius;
        private int defaultHighlightOffset;
        private int highlightAlphaTop = 255;
        private int highlightAlphaBottom;

        private bool increasingAlpha;

        private Timer animateButtonHighlightedTimer = new Timer();
        private Timer animateResumeNormalTimer = new Timer();

        #endregion

        #region Construction

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GelButton()
        {
        }

        #endregion

        #region Properties
        
        /// <summary>
        /// GradientTop
        /// </summary>
        [Category("Appearance")]
        [Description("The color to use for the top portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0x2C55B1")]
        
        public Color GradientTop
        {
            get
            {
                return gradientTop;
            }
            set
            {
                gradientTop = value;
                SetPaintColors();
                Invalidate();
            }
        }

        /// <summary>
        /// GradientBottom
        /// </summary>
        [Category("Appearance")]
        [Description("The color to use for the bottom portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0xffffff")]

        public Color GradientBottom
        {
            get
            {
                return gradientBottom;
            }
            set
            {
                gradientBottom = value;
                SetPaintColors();
                Invalidate();
            }
        }

        /// <summary>
        /// ForeColor
        /// </summary>
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                SetPaintColors();
                Invalidate();
            }
        }

        #endregion

        #region Initialization and Modification

        /// <summary>
        /// OnCreateControl
        /// </summary>
        protected override void OnCreateControl()
        {
            SuspendLayout();
            SetControlSizes();
            SetPaintColors();
            InitializeTimers();
            base.OnCreateControl();
            ResumeLayout();
        }

        /// <summary>
        /// OnResize
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnResize(EventArgs eventArgs_e)
        {
            SetControlSizes();
            this.Invalidate();
            base.OnResize(eventArgs_e);
        }

        /// <summary>
        /// SetControlSizes()
        /// </summary>
        private void SetControlSizes()
        {
            int scalingDividend = Math.Min(ClientRectangle.Width, ClientRectangle.Height);
            buttonRect = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            rectCornerRadius = Math.Max(1, scalingDividend / 10);
            rectOutlineWidth = Math.Max(1, scalingDividend / 50);
            highlightRect = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, (ClientRectangle.Height - 1) / 2);
            highlightRectOffset = Math.Max(1, scalingDividend / 35);
            defaultHighlightOffset = Math.Max(1, scalingDividend / 35);
        }

        /// <summary>
        /// OnEnabledChanged
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnEnabledChanged(EventArgs eventArgs_e)
        {
            if (!Enabled)
            {
                animateButtonHighlightedTimer.Stop();
                animateResumeNormalTimer.Stop();
            }
            SetPaintColors();
            Invalidate();
            base.OnEnabledChanged(eventArgs_e);
        }

        /// <summary>
        /// SetPaintColors
        /// </summary>
        private void SetPaintColors()
        {
            if (Enabled)
            {
                if (SystemInformation.HighContrast)
                {
                    paintGradientTop = Color.Black;
                    paintGradientBottom = Color.Black;
                    paintForeColor = Color.White;
                }
                else
                {
                    paintGradientTop = gradientTop;
                    paintGradientBottom = gradientBottom;
                    paintForeColor = ForeColor;
                }
            }
            else
            {
                if (SystemInformation.HighContrast)
                {
                    paintGradientTop = Color.Gray;
                    paintGradientBottom = Color.White;
                    paintForeColor = Color.Black;
                }
                else
                {
                    int grayscaleColorTop = (int)(gradientTop.GetBrightness() * 255);
                    paintGradientTop = Color.FromArgb(grayscaleColorTop, grayscaleColorTop, grayscaleColorTop);
                    int grayscaleGradientBottom = (int)(gradientBottom.GetBrightness() * 255);
                    paintGradientBottom = Color.FromArgb(grayscaleGradientBottom, grayscaleGradientBottom, grayscaleGradientBottom);
                    int grayscaleForeColor = (int)(ForeColor.GetBrightness() * 255);
                    if (grayscaleForeColor > 255 / 2)
                    {
                        grayscaleForeColor -= 60;
                    }
                    else
                    {
                        grayscaleForeColor += 60;
                    }
                    paintForeColor = Color.FromArgb(grayscaleForeColor, grayscaleForeColor, grayscaleForeColor);
                }
            }
        }

        /// <summary>
        /// InitializeTimers
        /// </summary>
        private void InitializeTimers()
        {
            animateButtonHighlightedTimer.Interval = 20;
            animateButtonHighlightedTimer.Tick += new EventHandler(animateButtonHighlightedTimer_Tick);
            animateResumeNormalTimer.Interval = 5;
            animateResumeNormalTimer.Tick += new EventHandler(animateResumeNormalTimer_Tick);
        }

        #endregion

        #region Custom Painting

        /// <summary>
        /// OnPaint
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            ButtonRenderer.DrawParentBackground(graphics, ClientRectangle, this);
            // Paint the outer rounded rectangle
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath outerPath = RoundedRectangle(buttonRect, rectCornerRadius, 0))
            {
                using (LinearGradientBrush outerBrush = new LinearGradientBrush(buttonRect, paintGradientTop, paintGradientBottom, LinearGradientMode.Vertical))
                {
                    graphics.FillPath(outerBrush, outerPath);
                }
                using (Pen outlinePen = new Pen(paintGradientTop, rectOutlineWidth))
                {
                    outlinePen.Alignment = PenAlignment.Inset;
                    graphics.DrawPath(outlinePen, outerPath);
                }
            }
            // If this is the default button, paint an additional highlight
            if (IsDefault)
            {
                using (GraphicsPath defaultPath = new GraphicsPath())
                {
                    defaultPath.AddPath(RoundedRectangle(buttonRect, rectCornerRadius, 0), false);
                    defaultPath.AddPath(RoundedRectangle(buttonRect, rectCornerRadius, defaultHighlightOffset), false);
                    using (PathGradientBrush defaultBrush = new PathGradientBrush(defaultPath))
                    {
                        defaultBrush.CenterColor = Color.FromArgb(50, Color.White);
                        defaultBrush.SurroundColors = new Color[] { Color.FromArgb(100, Color.White) };
                        graphics.FillPath(defaultBrush, defaultPath);
                    }
                }
            }
            // Paint the gel highlight
            using (GraphicsPath innerPath = RoundedRectangle(highlightRect, rectCornerRadius, highlightRectOffset))
            {
                using (LinearGradientBrush innerBrush = new LinearGradientBrush(highlightRect, Color.FromArgb(highlightAlphaTop, Color.White), Color.FromArgb(highlightAlphaBottom, Color.White), LinearGradientMode.Vertical))
                {
                    graphics.FillPath(innerBrush, innerPath);
                }
            }
            // Paint the text
            TextRenderer.DrawText(graphics, Text, Font, buttonRect, paintForeColor, Color.Transparent,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        /// <summary>
        /// RoundedRectangle
        /// </summary>
        /// <param name="boundingRect"></param>
        /// <param name="cornerRadius"></param>
        /// <param name="margin"></param>
        /// <returns></returns>
        private static GraphicsPath RoundedRectangle(Rectangle boundingRect, int cornerRadius, int margin)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(boundingRect.X + margin, boundingRect.Y + margin, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddArc(boundingRect.X + boundingRect.Width - margin - cornerRadius * 2, boundingRect.Y + margin, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddArc(boundingRect.X + boundingRect.Width - margin - cornerRadius * 2, boundingRect.Y + boundingRect.Height - margin - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddArc(boundingRect.X + margin, boundingRect.Y + boundingRect.Height - margin - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(boundingRect.X + margin, boundingRect.Y + boundingRect.Height - margin - cornerRadius * 2, boundingRect.X + margin, boundingRect.Y + margin + cornerRadius);
            roundedRect.CloseFigure();
            return roundedRect;
        }

        #endregion

        #region Mouse and Keyboard Interaction

        /// <summary>
        /// OnMouseEnter
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnMouseEnter(EventArgs eventArgs_e)
        {
            HighlightButton();
            base.OnMouseEnter(eventArgs_e);
        }

        /// <summary>
        /// OnGotFocus
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnGotFocus(EventArgs eventArgs_e)
        {
            HighlightButton();
            base.OnGotFocus(eventArgs_e);
        }

        /// <summary>
        /// HighlightButton
        /// </summary>
        private void HighlightButton()
        {
            if (Enabled)
            {
                animateResumeNormalTimer.Stop();
                animateButtonHighlightedTimer.Start();
            }
        }

        /// <summary>
        /// animateButtonHighlightedTimer_Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void animateButtonHighlightedTimer_Tick(object sender, EventArgs eventArgs_e)
        {
            if (increasingAlpha)
            {
                if (100 <= highlightAlphaBottom)
                {
                    increasingAlpha = false;
                }
                else
                {
                    highlightAlphaBottom += 5;
                }
            }
            else
            {
                if (0 >= highlightAlphaBottom)
                {
                    increasingAlpha = true;
                }
                else
                {
                    highlightAlphaBottom -= 5;
                }
            }
            Invalidate();
        }

        /// <summary>
        /// OnMouseLeave
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnMouseLeave(EventArgs eventArgs_e)
        {
            ResumeNormalButton();
            base.OnMouseLeave(eventArgs_e);
        }

        /// <summary>
        /// OnLostFocus
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnLostFocus(EventArgs eventArgs_e)
        {
            ResumeNormalButton();
            base.OnLostFocus(eventArgs_e);
        }

        /// <summary>
        /// ResumeNormalButton
        /// </summary>
        private void ResumeNormalButton()
        {
            if (Enabled)
            {
                animateButtonHighlightedTimer.Stop();
                animateResumeNormalTimer.Start();
            }
        }

        /// <summary>
        /// animateResumeNormalTimer_Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void animateResumeNormalTimer_Tick(object sender, EventArgs eventArgs_e)
        {
            bool modified = false;
            if (highlightAlphaBottom > 0)
            {
                highlightAlphaBottom -= 5;
                modified = true;
            }
            if (highlightAlphaTop < 255)
            {
                highlightAlphaTop += 5;
                modified = true;
            }
            if (!modified)
            {
                animateResumeNormalTimer.Stop();
            }
            Invalidate();
        }

        /// <summary>
        /// OnMouseDown
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnMouseDown(MouseEventArgs eventArgs_e)
        {
            PressButton();
            base.OnMouseDown(eventArgs_e);
        }

        /// <summary>
        /// OnKeyDown
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnKeyDown(KeyEventArgs eventArgs_e)
        {
            if (eventArgs_e.KeyCode == Keys.Space || eventArgs_e.KeyCode == Keys.Return)
            {
                PressButton();
            }
            base.OnKeyDown(eventArgs_e);
        }

        /// <summary>
        /// PressButton
        /// </summary>
        private void PressButton()
        {
            if (Enabled)
            {
                animateButtonHighlightedTimer.Stop();
                animateResumeNormalTimer.Stop();
                highlightRect.Location = new Point(0, ClientRectangle.Height / 2);
                highlightAlphaTop = 0;
                highlightAlphaBottom = 200;
                Invalidate();
            }
        }

        /// <summary>
        /// OnMouseUp
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnMouseUp(MouseEventArgs eventArgs_e)
        {
            ReleaseButton();
            if (DisplayRectangle.Contains(eventArgs_e.Location))
            {
                HighlightButton();
            }
            base.OnMouseUp(eventArgs_e);
        }

        /// <summary>
        /// OnKeyUp
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnKeyUp(KeyEventArgs eventArgs_e)
        {
            if (eventArgs_e.KeyCode == Keys.Space || eventArgs_e.KeyCode == Keys.Return)
            {
                ReleaseButton();
                if (IsDefault)
                {
                    HighlightButton();
                }
            }
            base.OnKeyUp(eventArgs_e);
        }

        /// <summary>
        /// OnMouseMove
        /// </summary>
        /// <param name="eventArgs_e"></param>
        protected override void OnMouseMove(MouseEventArgs eventArgs_e)
        {
            if (Enabled && (eventArgs_e.Button & MouseButtons.Left) == MouseButtons.Left && !ClientRectangle.Contains(eventArgs_e.Location))
            {
                ReleaseButton();
            }
            base.OnMouseMove(eventArgs_e);
        }

        /// <summary>
        /// ReleaseButton
        /// </summary>
        private void ReleaseButton()
        {
            if (Enabled)
            {
                highlightRect.Location = new Point(0, 0);
                highlightAlphaTop = 255;
                highlightAlphaBottom = 0;
            }
        }
        #endregion
    }
}