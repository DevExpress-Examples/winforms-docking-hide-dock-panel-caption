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
Imports System.ComponentModel
Imports System.Drawing
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

        ''' Fields...
        Private _ShowCaption As Boolean = True

        Public Property ShowCaption As Boolean
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

        Private Property DockLayout As CustomDockLayout
            Get
                Return TryCast(MyBase.DockLayout, CustomDockLayout)
            End Get

            Set(ByVal value As CustomDockLayout)
                MyBase.DockLayout = value
            End Set
        End Property
    End Class
End Namespace
