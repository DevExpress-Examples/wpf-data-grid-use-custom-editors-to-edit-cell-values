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
			grid.DataSource = Products.GetData()
		End Sub

		Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Wpf.Grid.GridColumnDataEventArgs)
			If e.Column.FieldName = "Total" Then
				e.Value = Convert.ToInt32(grid.GetCellValue(grid.GetRowHandleByListIndex(e.ListSourceRowIndex), "UnitPrice")) * Convert.ToDouble(grid.GetCellValue(grid.GetRowHandleByListIndex(e.ListSourceRowIndex), "UnitsOnOrder"))
			End If
		End Sub
	End Class

	Public Class Products
		Public Shared Function GetData() As List(Of Product)
			Dim data As New List(Of Product)()
			data.Add(New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10})
			data.Add(New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice=36.8, .UnitsOnOrder = 12})
			data.Add(New Product() With {.ProductName = "Outback Lager", .UnitPrice=12, .UnitsOnOrder = 25})
			data.Add(New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice=18.4, .UnitsOnOrder = 18})
			data.Add(New Product() With {.ProductName = "Konbu", .UnitPrice=6, .UnitsOnOrder = 24})
			Return data
		End Function
	End Class
	Public Class Product
		Private privateProductName As String
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property
		Private privateUnitPrice As Double
		Public Property UnitPrice() As Double
			Get
				Return privateUnitPrice
			End Get
			Set(ByVal value As Double)
				privateUnitPrice = value
			End Set
		End Property
		Private privateUnitsOnOrder As Integer
		Public Property UnitsOnOrder() As Integer
			Get
				Return privateUnitsOnOrder
			End Get
			Set(ByVal value As Integer)
				privateUnitsOnOrder = value
			End Set
		End Property
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
