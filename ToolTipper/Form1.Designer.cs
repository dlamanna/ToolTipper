using System.Drawing;
using System.Windows.Forms;

namespace ToolTipper
{
    partial class ToolTipper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private static Screen[] screens = Screen.AllScreens;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override bool ShowWithoutActivation // stops the window from stealing focus
        {
            get { return true; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.TooltipText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(350, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Tooltip_Click);
            // 
            // TooltipText
            // 
            this.TooltipText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TooltipText.AutoSize = true;
            this.TooltipText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TooltipText.Location = new System.Drawing.Point(5, 34);
            this.TooltipText.MaximumSize = new System.Drawing.Size(340, 200);
            this.TooltipText.MinimumSize = new System.Drawing.Size(340, 0);
            this.TooltipText.Name = "TooltipText";
            this.TooltipText.Size = new System.Drawing.Size(340, 18);
            this.TooltipText.TabIndex = 1;
            this.TooltipText.Text = "Tooltip Text";
            this.TooltipText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TooltipText.Click += new System.EventHandler(this.Tooltip_Click);
            // 
            // ToolTipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 90);
            this.Controls.Add(this.TooltipText);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(2705, 190);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 90);
            this.MinimumSize = new System.Drawing.Size(350, 90);
            this.Name = "ToolTipper";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tooltip";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.Tooltip_Load);
            this.Click += new System.EventHandler(this.Tooltip_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label TooltipText;
    }
}

