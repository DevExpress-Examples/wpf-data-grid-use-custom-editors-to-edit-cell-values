Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Markup

Namespace DXGrid_CustomEditors
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.GridColumnDataEventArgs)
			If e.Column.FieldName = "Total" Then
				e.Value = Convert.ToInt32(grid.GetCellValueByListIndex(e.ListSourceRowIndex, "UnitPrice")) * Convert.ToDouble(grid.GetCellValueByListIndex(e.ListSourceRowIndex, "UnitsOnOrder"))
			End If
		End Sub
	End Class

	Public Class IntToDoubleConverter
		Inherits MarkupExtension
		Implements IValueConverter
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
		Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return Convert.ToDouble(value)
		End Function
		Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Convert.ToInt32(value)
		End Function
	End Class
End Namespace
