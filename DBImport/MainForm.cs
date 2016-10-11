using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBImport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private LoadParamsView loadParamsView;
        private ShowProcessView showProcessView;

        private void Init()
        {
            pnlWorkArea.Dock = DockStyle.Fill;
            ShowLoadDataParams();
        }

        private void LoadSettings()
        {
            this.Top = Properties.Settings.Default.MainForm_Top;
            this.Left = Properties.Settings.Default.MainForm_Left;
            this.Width = Properties.Settings.Default.MainForm_Width;
            this.Height = Properties.Settings.Default.MainForm_Height;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.MainForm_Top = this.Top;
            Properties.Settings.Default.MainForm_Left = this.Left;
            Properties.Settings.Default.MainForm_Width = this.Width;
            Properties.Settings.Default.MainForm_Height = this.Height;

            Properties.Settings.Default.Save();
        }

        private void ShowLoadDataParams()
        {
            if (loadParamsView == null)
            {
                loadParamsView = new LoadParamsView();
                loadParamsView.FormBorderStyle = FormBorderStyle.None;
                loadParamsView.TopLevel = false;
                loadParamsView.AutoScroll = false;
                loadParamsView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                pnlWorkArea.Controls.Add(loadParamsView);
                loadParamsView.Dock = DockStyle.Fill;
            }
            loadParamsView.Show();
            loadParamsView.BringToFront();
        }

        private void ShowProcessView()
        {
            if (showProcessView == null)
            {
                showProcessView = new ShowProcessView();
                showProcessView.FormBorderStyle = FormBorderStyle.None;
                showProcessView.TopLevel = false;
                showProcessView.AutoScroll = false;
                showProcessView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                pnlWorkArea.Controls.Add(showProcessView);
                showProcessView.Dock = DockStyle.Fill;
            }
            showProcessView.Show();
            showProcessView.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void bbRun_Click(object sender, EventArgs e)
        {
            ShowProcessView();
            showProcessView.Execute();
        }
    }
}
