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
