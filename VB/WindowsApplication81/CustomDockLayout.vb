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
'INSTANT VB NOTE: The local variable hasCaption was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim hasCaption_Renamed As Boolean = MyBase.HasCaption
				Dim dockPanel As CustomDockPanel = TryCast(Panel, CustomDockPanel)
				Return dockPanel.ShowCaption AndAlso hasCaption_Renamed
			  ' return base.HasCaption;
			End Get
		End Property

		Public Shadows ReadOnly Property DockManager() As CustomDockManager
			Get
				Return TryCast(MyBase.DockManager, CustomDockManager)
			End Get
		End Property

		Friend Sub LayoutChanged()
			MyBase.LayoutChanged()
		End Sub
	End Class
End Namespace
