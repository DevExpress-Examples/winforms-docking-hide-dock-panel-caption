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
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsApplication81

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        'CustomDockPanel panel;
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler customDockManager1.RegisterDockPanel, AddressOf customDockManager1_RegisterDockPanel
        'CustomDockManager manager = new CustomDockManager(this);
        'panel = manager.AddPanel(DockingStyle.Left) as CustomDockPanel;
        'panel.Text = "dockPanel1";
        'panel = manager.AddPanel(DockingStyle.Left) as CustomDockPanel;
        'panel.Text = "dockPanel2";
        'panel.ShowCaption = false;
        End Sub

        Private parentPanel As CustomDockPanel = Nothing

        Private Sub customDockManager1_RegisterDockPanel(ByVal sender As Object, ByVal e As DockPanelEventArgs)
            'throw new NotImplementedException();
            'if (e.Panel==pane)
            If e.Panel.Text.Contains("container") Then parentPanel = TryCast(e.Panel, CustomDockPanel)
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TryCast(panelContainer1, CustomDockPanel).ShowCaption = checkEdit1.Checked
        End Sub
    End Class
End Namespace
