Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Docking
Imports System.Windows.Media

Namespace WpfApplication
	Public Class MainViewModel

		Public Sub New()
			DocumentViews.Add(New DocumentViewModel("Document1", "/Images/change.png"))
			DocumentViews.Add(New DocumentViewModel("Document2", "/Images/create.png"))
			DocumentViews.Add(New DocumentViewModel("Document2", "/Images/new-16x16.png"))
			ChildViews.Add(New PanelViewModel(Colors.Red))
			ChildViews.Add(New PanelViewModel(Colors.Blue))
			ChildViews.Add(New PanelViewModel(Colors.Green))
		End Sub

		Public Property ChildViews() As New ObservableCollection(Of Object)()


		Public Property DocumentViews() As New ObservableCollection(Of Object)()


	End Class
End Namespace