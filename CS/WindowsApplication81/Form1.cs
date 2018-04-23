// Developer Express Code Central Example:
// How to completely hide the dock panel's caption?
// 
// By setting the DockManager.DockingOptions.ShowCaptionOnMouseHover property it's
// possible to set whether the dock panel's caption is shown only when the mouse
// pointer hovers over the panel's top or all the time. This example demonstrates
// how to prevent the dock panel's caption from being shown for an individual dock
// panel all the time.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1940

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
        //CustomDockPanel panel;
        private void Form1_Load(object sender, EventArgs e) {
            customDockManager1.RegisterDockPanel += customDockManager1_RegisterDockPanel;
            //CustomDockManager manager = new CustomDockManager(this);
            //panel = manager.AddPanel(DockingStyle.Left) as CustomDockPanel;
            //panel.Text = "dockPanel1";
            //panel = manager.AddPanel(DockingStyle.Left) as CustomDockPanel;
            //panel.Text = "dockPanel2";
            //panel.ShowCaption = false;
        }
        CustomDockPanel parentPanel = null;
        void customDockManager1_RegisterDockPanel(object sender, DockPanelEventArgs e)
        {
            //throw new NotImplementedException();
            //if (e.Panel==pane)
            if (e.Panel.Text.Contains("container"))
                parentPanel = e.Panel as CustomDockPanel;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            (panelContainer1 as CustomDockPanel).ShowCaption = checkEdit1.Checked;
        }
    }
}