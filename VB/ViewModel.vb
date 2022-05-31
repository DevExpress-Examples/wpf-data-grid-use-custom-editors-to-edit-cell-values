Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace DXGrid_CustomEditors

    Public Class DemoViewModel
        Inherits ViewModelBase

        Public Sub New()
            Products = New ObservableCollection(Of Product)(GenerateData())
        End Sub

        Private Shared Iterator Function GenerateData() As IEnumerable(Of Product)
            Yield New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10}
            Yield New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice = 36.8, .UnitsOnOrder = 12}
            Yield New Product() With {.ProductName = "Outback Lager", .UnitPrice = 12, .UnitsOnOrder = 25}
            Yield New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice = 18.4, .UnitsOnOrder = 18}
            Yield New Product() With {.ProductName = "Konbu", .UnitPrice = 6, .UnitsOnOrder = 24}
        End Function

        Public Property Products As ObservableCollection(Of Product)
            Get
                Return GetValue(Of ObservableCollection(Of Product))(NameOf(DemoViewModel.Products))
            End Get

            Set(ByVal value As ObservableCollection(Of Product))
                SetValue(value, NameOf(DemoViewModel.Products))
            End Set
        End Property
    End Class

    Public Class Product
        Inherits BindableBase

        Public Property ProductName As String
            Get
                Return GetValue(Of String)(NameOf(Product.ProductName))
            End Get

            Set(ByVal value As String)
                SetValue(value, NameOf(Product.ProductName))
            End Set
        End Property

        Public Property UnitPrice As Double
            Get
                Return GetValue(Of Double)(NameOf(Product.UnitPrice))
            End Get

            Set(ByVal value As Double)
                SetValue(value, NameOf(Product.UnitPrice))
            End Set
        End Property

        Public Property UnitsOnOrder As Integer
            Get
                Return GetValue(Of Integer)(NameOf(Product.UnitsOnOrder))
            End Get

            Set(ByVal value As Integer)
                SetValue(value, NameOf(Product.UnitsOnOrder))
            End Set
        End Property
    End Class
End Namespace
