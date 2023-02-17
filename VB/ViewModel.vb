Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DXGrid_CustomEditors

    Public Class DemoViewModel
        Inherits ViewModelBase

        Private _products As ObservableCollection(Of Product)

        Public Sub New()
            Products = GenerateData()
        End Sub

        Private Function GenerateData() As ObservableCollection(Of Product)
            Dim data As ObservableCollection(Of Product) = New ObservableCollection(Of Product)()
            data.Add(New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10})
            data.Add(New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice = 36.8, .UnitsOnOrder = 12})
            data.Add(New Product() With {.ProductName = "Outback Lager", .UnitPrice = 12, .UnitsOnOrder = 25})
            data.Add(New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice = 18.4, .UnitsOnOrder = 18})
            data.Add(New Product() With {.ProductName = "Konbu", .UnitPrice = 6, .UnitsOnOrder = 24})
            Return data
        End Function

        Public Property Products As ObservableCollection(Of Product)
            Get
                Return _products
            End Get

            Set(ByVal value As ObservableCollection(Of Product))
                If value Is _products Then Return
                _products = value
                RaisePropertyChanged("Products")
            End Set
        End Property
    End Class

    Public Class Product
        Inherits BindableBase

        Public Property ProductName As String
            Get
                Return GetProperty(Function() Me.ProductName)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() ProductName, value)
            End Set
        End Property

        Public Property UnitPrice As Double
            Get
                Return GetProperty(Function() Me.UnitPrice)
            End Get

            Set(ByVal value As Double)
                SetProperty(Function() UnitPrice, value)
            End Set
        End Property

        Public Property UnitsOnOrder As Integer
            Get
                Return GetProperty(Function() Me.UnitsOnOrder)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() UnitsOnOrder, value)
            End Set
        End Property
    End Class
End Namespace
