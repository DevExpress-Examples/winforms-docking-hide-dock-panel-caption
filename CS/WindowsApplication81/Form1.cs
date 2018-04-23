using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;

namespace WindowsApplication81 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        CustomDockPanel panel;
        private void Form1_Load(object sender, EventArgs e) {
            CustomDockManager manager = new CustomDockManager(this);
            panel = manager.AddPanel(DockingStyle.Left) as CustomDockPanel;
            panel.Text = "dockPanel1";
            panel = manager.AddPanel(DockingStyle.Left) as CustomDockPanel;
            panel.Text = "dockPanel2";
            panel.ShowCaption = false;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            panel.ShowCaption = checkEdit1.Checked;
        }
    }
}