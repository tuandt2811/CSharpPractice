using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpeedUpWork
{
    public partial class MainFrame : Form
    {
        Testing testView = null;
        Enviroment enviView = null;
        BuildPlugin pluginView = null;
        ProjectExplorer projectView = null;
        int MainWidth = 0;
        int MainHeight = 0;

        int projectViewWidth = 0;
        int projectViewHeight = 0;

        public MainFrame()
        {
            InitializeComponent();
            MainWidth = Screen.PrimaryScreen.Bounds.Width;
            MainHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(MainWidth, MainHeight);
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle DisplayView;

            testView = new Testing();
            enviView = new Enviroment();
            pluginView = new BuildPlugin();
            projectView = new ProjectExplorer();

            testView.MdiParent = this;
            enviView.MdiParent = this;
            pluginView.MdiParent = this;
            projectView.MdiParent = this;

            projectViewHeight = MainHeight;
            projectViewWidth = 200;
            DisplayView = this.ClientRectangle;
            projectView.Location = new Point(DisplayView.X, DisplayView.Y);
            projectView.Size = new Size(projectViewWidth, projectViewHeight);
            projectView.Show();

            testView.Show();
            enviView.Show();
            pluginView.Show();

            
        }

    }
}
