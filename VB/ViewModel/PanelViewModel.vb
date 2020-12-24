Imports System
Imports System.Linq
Imports System.Windows.Media
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.UI
Imports DevExpress.Xpf.Docking

Namespace WpfApplication
	Public Interface IDockService
		Function Dock() As Boolean
		Function Float() As FloatGroup
	End Interface

	Public Class DockService
		Inherits ServiceBase
		Implements IDockService

		Private Panel As LayoutPanel

		Private Function IDockService_Dock() As Boolean Implements IDockService.Dock
			Return Panel.GetDockLayoutManager().DockController.Dock(Panel)
		End Function
		Private Function IDockService_Float() As FloatGroup Implements IDockService.Float
			Return Panel.GetDockLayoutManager().DockController.Float(Panel)
		End Function

		Protected Overrides Sub OnAttached()
			MyBase.OnAttached()
			Panel = TryCast(AssociatedObject, LayoutPanel)
		End Sub
	End Class
	Public Class PanelViewModel
		Inherits ViewModelBase

		Public Sub New(ByVal c As Color)
			ColorBrush = New SolidColorBrush(c)
			FloatCommand = New DelegateCommand(AddressOf Float)
			DockCommand = New DelegateCommand(AddressOf Dock)
		End Sub

		Public Property ColorBrush() As SolidColorBrush
		Private privateDockCommand As DelegateCommand
		Public Property DockCommand() As DelegateCommand
			Get
				Return privateDockCommand
			End Get
			Private Set(ByVal value As DelegateCommand)
				privateDockCommand = value
			End Set
		End Property
		Private privateFloatCommand As DelegateCommand
		Public Property FloatCommand() As DelegateCommand
			Get
				Return privateFloatCommand
			End Get
			Private Set(ByVal value As DelegateCommand)
				privateFloatCommand = value
			End Set
		End Property
		Private ReadOnly Property DockService() As IDockService
			Get
				Return GetService(Of IDockService)()
			End Get
		End Property

		Private Sub Dock()
			DockService.Dock()
		End Sub
		Private Sub Float()
			DockService.Float()
		End Sub
	End Class
End Namespace
