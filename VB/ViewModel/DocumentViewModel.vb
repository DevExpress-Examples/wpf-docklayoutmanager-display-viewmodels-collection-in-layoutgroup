Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.Docking

Namespace WpfApplication
	Public Class DocumentViewModel
		Inherits IMVVMDockingProperties


		Public Sub New(ByVal caption As String, ByVal imagePath As String)
			Me.Caption = caption
			Glyph = GlyphHelper.GetGlyph(imagePath)
			Text = String.Format("Document text ({0})", caption)
		End Sub

		Public Property Caption() As String
		Public Property Glyph() As Object
		Public Property Text() As String
		Public Property TargetName() As String
			Get
'INSTANT VB TODO TASK: Throw expressions are not converted by Instant VB:
'ORIGINAL LINE: return throw new NotImplementedException();
				Return throw New NotImplementedException()
			End Get
			Set(ByVal value As String)
				Throw New NotImplementedException()
			End Set
		End Property
	End Class
End Namespace
