Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace DXGrid_CustomEditors

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.GridColumnDataEventArgs)
            If Equals(e.Column.FieldName, "Total") Then
                e.Value = Convert.ToInt32(Me.grid.GetCellValueByListIndex(e.ListSourceRowIndex, "UnitPrice")) * Convert.ToDouble(Me.grid.GetCellValueByListIndex(e.ListSourceRowIndex, "UnitsOnOrder"))
            End If
        End Sub
    End Class

    Public Class IntToDoubleConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Private Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return System.Convert.ToDouble(value)
        End Function

        Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return System.Convert.ToInt32(value)
        End Function
    End Class
End Namespace
