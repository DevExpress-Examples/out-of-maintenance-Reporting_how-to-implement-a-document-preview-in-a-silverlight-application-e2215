Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub showReport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			preview.Model.CreateDocument()
		End Sub
	End Class
End Namespace
