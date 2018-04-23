Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel

Namespace DXGrid_CustomEditors
	Public Class DemoViewModel
		Implements INotifyPropertyChanged
		Private products_Renamed As List(Of Product)
		Public Sub New()
			Products = GenerateData()
		End Sub
		Private Function GenerateData() As List(Of Product)
			Dim data As New List(Of Product)()
			data.Add(New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10})
			data.Add(New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice = 36.8, .UnitsOnOrder = 12})
			data.Add(New Product() With {.ProductName = "Outback Lager", .UnitPrice = 12, .UnitsOnOrder = 25})
			data.Add(New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice = 18.4, .UnitsOnOrder = 18})
			data.Add(New Product() With {.ProductName = "Konbu", .UnitPrice = 6, .UnitsOnOrder = 24})
			Return data
		End Function
		Public Property Products() As List(Of Product)
			Get
				Return products_Renamed
			End Get
			Set(ByVal value As List(Of Product))
				If value Is products_Renamed Then
					Return
				End If
				products_Renamed = value
				NotifyPropertyChanged("Products")
			End Set
		End Property

		#Region "INotifyPropertyChanged"
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Private Sub NotifyPropertyChanged(ByVal info As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End Sub
		#End Region
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
End Namespace
