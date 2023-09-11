' Developer Express Code Central Example:
' How to completely hide the dock panel's caption?
' 
' By setting the DockManager.DockingOptions.ShowCaptionOnMouseHover property it's
' possible to set whether the dock panel's caption is shown only when the mouse
' pointer hovers over the panel's top or all the time. This example demonstrates
' how to prevent the dock panel's caption from being shown for an individual dock
' panel all the time.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1940
Namespace WindowsApplication81

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.customDockManager1 = New WindowsApplication81.CustomDockManager(Me.components)
            Me.customDockPanel1 = New WindowsApplication81.CustomDockPanel()
            Me.customDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelContainer1 = New WindowsApplication81.CustomDockPanel()
            Me.panel = New WindowsApplication81.CustomDockPanel()
            Me.customDockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.customDockPanel2 = New WindowsApplication81.CustomDockPanel()
            Me.controlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.customDockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.customDockPanel1.SuspendLayout()
            Me.customDockPanel1_Container.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.panel.SuspendLayout()
            Me.customDockPanel2.SuspendLayout()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(20, 39)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "ShowCaptionForPanel2"
            Me.checkEdit1.Size = New System.Drawing.Size(135, 19)
            Me.checkEdit1.TabIndex = 0
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' customDockManager1
            ' 
            Me.customDockManager1.Form = Me
            Me.customDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.customDockPanel1, Me.panelContainer1})
            Me.customDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' customDockPanel1
            ' 
            Me.customDockPanel1.Controls.Add(Me.customDockPanel1_Container)
            Me.customDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.customDockPanel1.ID = New System.Guid("6a7535ec-2b3d-4fc2-927b-20a81ebe4b67")
            Me.customDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.customDockPanel1.Name = "customDockPanel1"
            Me.customDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.customDockPanel1.ShowCaption = True
            Me.customDockPanel1.Size = New System.Drawing.Size(200, 474)
            Me.customDockPanel1.Text = "customDockPanel1"
            ' 
            ' customDockPanel1_Container
            ' 
            Me.customDockPanel1_Container.Controls.Add(Me.checkEdit1)
            Me.customDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            Me.customDockPanel1_Container.Name = "customDockPanel1_Container"
            Me.customDockPanel1_Container.Size = New System.Drawing.Size(192, 447)
            Me.customDockPanel1_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.panel
            Me.panelContainer1.Controls.Add(Me.customDockPanel2)
            Me.panelContainer1.Controls.Add(Me.panel)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.panelContainer1.FloatVertical = True
            Me.panelContainer1.ID = New System.Guid("0044980f-cac1-41b8-a9f2-3684963fcb7d")
            Me.panelContainer1.Location = New System.Drawing.Point(200, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.ShowCaption = True
            Me.panelContainer1.Size = New System.Drawing.Size(200, 474)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Top
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' panel
            ' 
            Me.panel.Controls.Add(Me.customDockPanel2_Container)
            Me.panel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.panel.FloatVertical = True
            Me.panel.ID = New System.Guid("a7af2d32-bb4b-4725-b915-18cac28239ee")
            Me.panel.Location = New System.Drawing.Point(4, 50)
            Me.panel.Name = "panel"
            Me.panel.OriginalSize = New System.Drawing.Size(192, 420)
            Me.panel.ShowCaption = True
            Me.panel.Size = New System.Drawing.Size(192, 420)
            Me.panel.Text = "customDockPanel2"
            ' 
            ' customDockPanel2_Container
            ' 
            Me.customDockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.customDockPanel2_Container.Name = "customDockPanel2_Container"
            Me.customDockPanel2_Container.Size = New System.Drawing.Size(192, 420)
            Me.customDockPanel2_Container.TabIndex = 0
            ' 
            ' customDockPanel2
            ' 
            Me.customDockPanel2.Controls.Add(Me.controlContainer1)
            Me.customDockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.customDockPanel2.ID = New System.Guid("3289b6ad-932b-448b-bbc1-aa43a2b01a75")
            Me.customDockPanel2.Location = New System.Drawing.Point(4, 50)
            Me.customDockPanel2.Name = "customDockPanel2"
            Me.customDockPanel2.OriginalSize = New System.Drawing.Size(192, 420)
            Me.customDockPanel2.ShowCaption = True
            Me.customDockPanel2.Size = New System.Drawing.Size(192, 420)
            Me.customDockPanel2.Text = "customDockPanel2"
            ' 
            ' controlContainer1
            ' 
            Me.controlContainer1.Location = New System.Drawing.Point(0, 0)
            Me.controlContainer1.Name = "controlContainer1"
            Me.controlContainer1.Size = New System.Drawing.Size(192, 420)
            Me.controlContainer1.TabIndex = 0
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView1})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(821, 474)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.customDockPanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.customDockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.customDockPanel1.ResumeLayout(False)
            Me.customDockPanel1_Container.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.panel.ResumeLayout(False)
            Me.customDockPanel2.ResumeLayout(False)
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private customDockManager1 As WindowsApplication81.CustomDockManager

        Private panel As WindowsApplication81.CustomDockPanel

        Private customDockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private customDockPanel1 As WindowsApplication81.CustomDockPanel

        Private customDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private panelContainer1 As WindowsApplication81.CustomDockPanel

        Private customDockPanel2 As WindowsApplication81.CustomDockPanel

        Private controlContainer1 As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager

        Private tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    End Class
End Namespace
