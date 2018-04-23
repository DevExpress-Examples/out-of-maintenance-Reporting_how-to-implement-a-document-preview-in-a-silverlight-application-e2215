Imports Microsoft.VisualBasic
Imports System.ServiceModel
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.UI

Namespace SilverlightApplication1.Web
	<SilverlightFaultBehavior> _
	Public Class DemoReportService
		Inherits DevExpress.XtraReports.Service.ReportService
		Protected Overrides Sub FillDataSources(ByVal report As XtraReport, ByVal reportName As String, ByVal isDesignActive As Boolean)
		End Sub

		Protected Overrides Sub SaveReportLayout(ByVal reportName As String, ByVal layoutData() As Byte)
			Throw New FaultException("This method is not implemented." & "Implement the SaveReportLayout method on the server-side, in the report service code-behind.")
		End Sub
	End Class
End Namespace
