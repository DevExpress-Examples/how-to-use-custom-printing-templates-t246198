Imports System
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI

Namespace SLGridExample.Web
    ' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in code, svc and config file together.
    <SilverlightFaultBehavior> _
    Public Class ReportService
        Inherits DevExpress.XtraReports.Service.ReportService

        ' Un-comment this method if you need to extend the base functionality.
        ' protected override XtraReport CreateReportByName(string reportName)
        ' {
        '	return base.CreateReportByName(reportName);
        ' }
    End Class
End Namespace
