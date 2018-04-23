' Developer Express Code Central Example:
' How to use custom printing templates
' 
' This example demonstrates how to use grid's printing templates to change the
' grid printing appearance.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3228

Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Resources
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports GridExample
Imports System.Collections.Generic
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Core


Namespace SLGridExample
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()

            AddHandler Loaded, AddressOf MainPage_Loaded
        End Sub

        Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.ItemsSource = New List(Of TestData)() From { _
                New TestData() With {.PlainText = "Mercedes-Benz SLK", .MemoText = "LMA AG " & ControlChars.Lf & "2004 " & ControlChars.Lf & "Silver", .BooleanMember = True, .Image = GetImage("/SLGridExample;component/Images/1.jpg"), .Price = 25}, _
                New TestData() With {.PlainText = "Rolls-Royce Corniche", .MemoText ="Western Motors " & ControlChars.Lf & "1975 " & ControlChars.Lf & "Snowy whight", .BooleanMember = False, .Image = GetImage("/SLGridExample;component/Images/2.jpg"), .Price = 15}, _
                New TestData() With {.PlainText = "Ford Ranger FX-4", .MemoText = "Sun car rent" & ControlChars.Lf & "1999 " & ControlChars.Lf & "Red rock", .BooleanMember = True, .Image = GetImage("/SLGridExample;component/Images/3.jpg"), .Price = 20} _
            }
        End Sub

        Private Function GetImage(ByVal path As String) As ImageSource

            Dim sr As StreamResourceInfo = Application.GetResourceStream(New Uri(path, UriKind.Relative))
            Dim bmp As New BitmapImage()
            bmp.SetSource(sr.Stream)

            Return bmp
        End Function

        Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ShowPrintPreview(grid)
        End Sub

        Private Sub ShowPrintPreview(ByVal grid As GridControl)
            Dim preview As New DocumentPreview()
            Dim link As New PrintableControlLink(TryCast(grid.View, IPrintableControl))
            link.ExportServiceUri = "../ExportService.svc"
            Dim model As New LinkPreviewModel(link)
            preview.Model = model

            link.CreateDocument(True)
            Dim dlg As New DXDialog()
            dlg.Content = preview
            dlg.Height = 640
            dlg.Left = 150
            dlg.Top = 150
            dlg.ShowDialog()
        End Sub
    End Class
End Namespace
