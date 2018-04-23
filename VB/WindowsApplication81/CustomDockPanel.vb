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
	Public Class CustomDockPanel
		Inherits DockPanel
		Public Sub New()
			Me.New(False, DockingStyle.Float, Nothing)
		End Sub
		Public Sub New(ByVal createControlContainer As Boolean, ByVal dock As DockingStyle, ByVal dockManager As DockManager)
			MyBase.New(createControlContainer, dock, dockManager)
			DockLayout = New CustomDockLayout(dock, Me)
		End Sub

		'// Fields...

		Private _ShowCaption As Boolean = True

		Public Property ShowCaption() As Boolean
			Get
				Return _ShowCaption
			End Get
			Set(ByVal value As Boolean)
				If _ShowCaption <> value Then
					_ShowCaption = value
					DockLayout.LayoutChanged()
				End If
			End Set
		End Property

		Private Overloads Property DockLayout() As CustomDockLayout
			Get
				Return TryCast(MyBase.DockLayout, CustomDockLayout)
			End Get
			Set(ByVal value As CustomDockLayout)
				MyBase.DockLayout = value
			End Set
		End Property
	End Class
End Namespace
