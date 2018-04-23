Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsApplication81
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private panel As CustomDockPanel
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim manager As New CustomDockManager(Me)
			panel = TryCast(manager.AddPanel(DockingStyle.Left), CustomDockPanel)
			panel.Text = "dockPanel1"
			panel = TryCast(manager.AddPanel(DockingStyle.Left), CustomDockPanel)
			panel.Text = "dockPanel2"
			panel.ShowCaption = False
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			panel.ShowCaption = checkEdit1.Checked
		End Sub
	End Class
End Namespace