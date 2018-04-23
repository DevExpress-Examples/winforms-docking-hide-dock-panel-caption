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
	Public Class CustomDockManager
		Inherits DockManager
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal form As ContainerControl)
			MyBase.New(form)
		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub
		Protected Overrides Function CreateDockPanel(ByVal dock As DockingStyle, ByVal createControlContainer As Boolean) As DockPanel
			Return New CustomDockPanel(createControlContainer, dock, Me)
		End Function
	End Class
End Namespace
