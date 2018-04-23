' Developer Express Code Central Example:
' How to use custom printing templates
' 
' This example demonstrates how to use grid's printing templates to change the
' grid printing appearance.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3228

Imports System
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI

Namespace SLGridExample.Web
    ' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in code, svc and config file together.
    <SilverlightFaultBehavior> _
    Public Class ReportService
        Inherits DevExpress.XtraReports.Service.ReportService

        Protected Overrides Sub FillDataSources(ByVal report As XtraReport, ByVal reportName As String, ByVal isDesignActive As Boolean)
        End Sub

        Protected Overrides Sub SaveReportLayout(ByVal reportName As String, ByVal layoutData() As Byte)
            Throw New FaultException("This method is not implemented. Implement the SaveReportLayout method on the server-side, in the report service code-behind.")
        End Sub
    End Class
End Namespace
