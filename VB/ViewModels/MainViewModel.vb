Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace WpfApplication.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property DocumentViews As ObservableCollection(Of PanelViewModel)
            Get
                Return GetValue(Of ObservableCollection(Of PanelViewModel))()
            End Get

            Set(ByVal value As ObservableCollection(Of PanelViewModel))
                SetValue(value)
            End Set
        End Property

        Public Property LayoutViews As ObservableCollection(Of PanelViewModel)
            Get
                Return GetValue(Of ObservableCollection(Of PanelViewModel))()
            End Get

            Set(ByVal value As ObservableCollection(Of PanelViewModel))
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            DocumentViews = New ObservableCollection(Of PanelViewModel)() From {New DocumentViewModel() With {.Caption = "Document1", .Content = "A document panel", .Glyph = "/Images/change.png"}, New DocumentViewModel() With {.Caption = "Document2", .Content = "A document panel", .Glyph = "/Images/create.png"}, New DocumentViewModel() With {.Caption = "Document3", .Content = "A document panel", .Glyph = "/Images/new-16x16.png"}, New DocumentViewModel() With {.Caption = "Document4", .Content = "A document panel"}}
            LayoutViews = New ObservableCollection(Of PanelViewModel)() From {New PanelViewModel() With {.Caption = "One", .Content = "A regular panel"}, New PanelViewModel() With {.Caption = "Two", .Content = "A regular panel"}, New PanelViewModel() With {.Caption = "Three", .Content = "A regular panel"}, New PanelViewModel() With {.Caption = "Five", .Content = "A regular panel"}}
        End Sub
    End Class

    Public Class PanelViewModel
        Inherits ViewModelBase

        Public Property Caption As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property Content As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class DocumentViewModel
        Inherits PanelViewModel

        Public Property Glyph As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
