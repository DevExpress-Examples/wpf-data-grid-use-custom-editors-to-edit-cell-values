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
            data.Add(New Product() With { _
                .ProductName = "Chai", _
                .UnitPrice = 18, _
                .UnitsOnOrder = 10 _
            })
            data.Add(New Product() With { _
                .ProductName = "Ipoh Coffee", _
                .UnitPrice = 36.8, _
                .UnitsOnOrder = 12 _
            })
            data.Add(New Product() With { _
                .ProductName = "Outback Lager", _
                .UnitPrice = 12, _
                .UnitsOnOrder = 25 _
            })
            data.Add(New Product() With { _
                .ProductName = "Boston Crab Meat", _
                .UnitPrice = 18.4, _
                .UnitsOnOrder = 18 _
            })
            data.Add(New Product() With { _
                .ProductName = "Konbu", _
                .UnitPrice = 6, _
                .UnitsOnOrder = 24 _
            })
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
        Public Property ProductName() As String
        Public Property UnitPrice() As Double
        Public Property UnitsOnOrder() As Integer
    End Class
End Namespace
