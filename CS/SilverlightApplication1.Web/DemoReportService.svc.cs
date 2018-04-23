using System.ServiceModel;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.UI;

namespace SilverlightApplication1.Web {
    [SilverlightFaultBehavior]
    public class DemoReportService : DevExpress.XtraReports.Service.ReportService {
        protected override void FillDataSources(XtraReport report, string reportName, bool isDesignActive) {
        }

        protected override void SaveReportLayout(string reportName, byte[] layoutData) {
            throw new FaultException("This method is not implemented." + 
                                     "Implement the SaveReportLayout method on the server-side, in the report service code-behind.");
        }
    }
}
