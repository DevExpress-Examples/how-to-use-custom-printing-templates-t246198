' Developer Express Code Central Example:
' How to use custom printing templates
' 
' This example demonstrates how to use grid's printing templates to change the
' grid printing appearance.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3228

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Media

Namespace GridExample
    Public Class TestData
        Public Property PlainText() As String
        Public Property MemoText() As String
        Public Property Price() As Double
        Public Property BooleanMember() As Boolean
        Public Property Image() As ImageSource
    End Class
End Namespace
