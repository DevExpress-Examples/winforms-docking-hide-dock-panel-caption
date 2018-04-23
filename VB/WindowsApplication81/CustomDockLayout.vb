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
	Public Class CustomDockLayout
		Inherits DockLayout
		Public Sub New(ByVal dock As DockingStyle, ByVal panel As DockPanel)
			MyBase.New(dock, panel)
		End Sub
		Public Sub New(ByVal dock As DockingStyle, ByVal size As Size, ByVal panel As DockPanel)
			MyBase.New(dock, size, panel)
		End Sub
		Protected Overrides ReadOnly Property HasCaption() As Boolean
			Get
				Dim dockPanel As CustomDockPanel = TryCast(Panel, CustomDockPanel)
				Return dockPanel.ShowCaption
				'return base.HasCaption;
			End Get
		End Property

		Public Shadows ReadOnly Property DockManager() As CustomDockManager
			Get
				Return TryCast(MyBase.DockManager, CustomDockManager)
			End Get
		End Property

		Friend Overloads Sub LayoutChanged()
			MyBase.LayoutChanged()
		End Sub
	End Class
End Namespace
