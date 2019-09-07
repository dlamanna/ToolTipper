using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ToolTipper
{
    public partial class ToolTipper : Form
    {
        private Timer tooltipTimer;
        private string tempString;

        public ToolTipper(string[] args)
        {
            Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            Properties.Settings.scanSettings();
            InitializeComponent();

            this.Title.Text = this.TooltipText.Text = tempString = "";
            if (args.Length > 0)
            {
                if (args.Length == 1)
                {
                    string[] operands = Regex.Split(args[0], @"\s+");
                    this.Title.Text = operands[0];
                    for (int i = 1; i < operands.Length; i++)
                    {
                        tempString += (operands[i] + " ");
                    }
                    this.TooltipText.Text = tempString;
                }
                else
                {
                    this.Title.Text = args[0];
                    for (int i = 1; i < args.Length; i++)
                    {
                        tempString += (args[i] + " ");
                    }
                    this.TooltipText.Text = tempString;
                }
            }
            else
            {
                this.Title.Text = "title";
                this.TooltipText.Text = "body body";
            }
        }
        private void Tooltip_Click(object sender, EventArgs e)
        {
            //create timer to fade out
            tooltipTimer = new Timer();
            tooltipTimer.Interval = 40;
            tooltipTimer.Tick += delegate { TimerTick(tooltipTimer, EventArgs.Empty); };
            tooltipTimer.Enabled = true;
        }
        private void Tooltip_Load(object sender, EventArgs e)
        {
            GlobalVar.formSize = this.MaximumSize.Width;
            //Setting Position
            GlobalVar.setCentered(Screen.FromPoint(Properties.Settings.positionSave),this);
            /*GlobalVar.setBounds();
            this.Location = new System.Drawing.Point(GlobalVar.widthAdder - (GlobalVar.formSize / 2), 20 + GlobalVar.heightDiff);
            this.Top = GlobalVar.heightDiff+20;
            this.Left = GlobalVar.widthAdder - (this.Size.Width / 2);*/

            //Getting data from settings.ini
            this.BackColor = this.Title.BackColor = this.TooltipText.BackColor = Properties.Settings.backgroundColor;
            this.TooltipText.ForeColor = this.Title.ForeColor = Properties.Settings.foregroundColor;
        }
        public void TimerTick(object sender, EventArgs e)
        {
            if (this.Opacity > .1)
            {
                this.Opacity -= 0.095D;
            }
            else
            {
                this.Enabled = false;
                this.Close();
                Close();
            }
        }
    }
}
