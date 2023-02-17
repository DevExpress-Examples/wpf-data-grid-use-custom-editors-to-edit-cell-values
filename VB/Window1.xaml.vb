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
    End Class

    Public Class IntToDoubleConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Private Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If TypeOf value Is Integer Then Return System.Convert.ToDouble(value)
            Return Double.NaN
        End Function

        Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return System.Convert.ToInt32(value)
        End Function
    End Class
End Namespace
