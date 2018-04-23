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

namespace WindowsApplication81 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.customDockManager1 = new WindowsApplication81.CustomDockManager(this.components);
            this.customDockPanel1 = new WindowsApplication81.CustomDockPanel();
            this.customDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelContainer1 = new WindowsApplication81.CustomDockPanel();
            this.panel = new WindowsApplication81.CustomDockPanel();
            this.customDockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.customDockPanel2 = new WindowsApplication81.CustomDockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDockManager1)).BeginInit();
            this.customDockPanel1.SuspendLayout();
            this.customDockPanel1_Container.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.panel.SuspendLayout();
            this.customDockPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(20, 39);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "ShowCaptionForPanel2";
            this.checkEdit1.Size = new System.Drawing.Size(135, 19);
            this.checkEdit1.TabIndex = 0;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // customDockManager1
            // 
            this.customDockManager1.Form = this;
            this.customDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.customDockPanel1,
            this.panelContainer1});
            this.customDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // customDockPanel1
            // 
            this.customDockPanel1.Controls.Add(this.customDockPanel1_Container);
            this.customDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.customDockPanel1.ID = new System.Guid("6a7535ec-2b3d-4fc2-927b-20a81ebe4b67");
            this.customDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.customDockPanel1.Name = "customDockPanel1";
            this.customDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.customDockPanel1.ShowCaption = true;
            this.customDockPanel1.Size = new System.Drawing.Size(200, 474);
            this.customDockPanel1.Text = "customDockPanel1";
            // 
            // customDockPanel1_Container
            // 
            this.customDockPanel1_Container.Controls.Add(this.checkEdit1);
            this.customDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.customDockPanel1_Container.Name = "customDockPanel1_Container";
            this.customDockPanel1_Container.Size = new System.Drawing.Size(192, 447);
            this.customDockPanel1_Container.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.panel;
            this.panelContainer1.Controls.Add(this.customDockPanel2);
            this.panelContainer1.Controls.Add(this.panel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("0044980f-cac1-41b8-a9f2-3684963fcb7d");
            this.panelContainer1.Location = new System.Drawing.Point(200, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.ShowCaption = true;
            this.panelContainer1.Size = new System.Drawing.Size(200, 474);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Top;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.customDockPanel2_Container);
            this.panel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.panel.FloatVertical = true;
            this.panel.ID = new System.Guid("a7af2d32-bb4b-4725-b915-18cac28239ee");
            this.panel.Location = new System.Drawing.Point(4, 50);
            this.panel.Name = "panel";
            this.panel.OriginalSize = new System.Drawing.Size(192, 420);
            this.panel.ShowCaption = true;
            this.panel.Size = new System.Drawing.Size(192, 420);
            this.panel.Text = "customDockPanel2";
            // 
            // customDockPanel2_Container
            // 
            this.customDockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.customDockPanel2_Container.Name = "customDockPanel2_Container";
            this.customDockPanel2_Container.Size = new System.Drawing.Size(192, 420);
            this.customDockPanel2_Container.TabIndex = 0;
            // 
            // customDockPanel2
            // 
            this.customDockPanel2.Controls.Add(this.controlContainer1);
            this.customDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.customDockPanel2.ID = new System.Guid("3289b6ad-932b-448b-bbc1-aa43a2b01a75");
            this.customDockPanel2.Location = new System.Drawing.Point(4, 50);
            this.customDockPanel2.Name = "customDockPanel2";
            this.customDockPanel2.OriginalSize = new System.Drawing.Size(192, 420);
            this.customDockPanel2.ShowCaption = true;
            this.customDockPanel2.Size = new System.Drawing.Size(192, 420);
            this.customDockPanel2.Text = "customDockPanel2";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(192, 420);
            this.controlContainer1.TabIndex = 0;
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.customDockPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDockManager1)).EndInit();
            this.customDockPanel1.ResumeLayout(false);
            this.customDockPanel1_Container.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.customDockPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private CustomDockManager customDockManager1;
        private CustomDockPanel panel;
        private DevExpress.XtraBars.Docking.ControlContainer customDockPanel2_Container;
        private CustomDockPanel customDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer customDockPanel1_Container;
        private CustomDockPanel panelContainer1;
        private CustomDockPanel customDockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;

    }
}

