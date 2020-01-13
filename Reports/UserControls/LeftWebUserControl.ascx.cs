using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Reports_UserControls_LeftWebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void lnkCommunication_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmCommunicationReport.aspx");
    }
    protected void lnkHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmReportsHome.aspx");
    }
    protected void lnkLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
    protected void lnkFeedBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmFeedbackReport.aspx");
    }
    protected void LinkCertificate_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmCertificateReport.aspx");
    }
    protected void LinkAuditor_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmAuditorReport.aspx");
    }
    protected void LinkByDates_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmEnquiryReportByDate.aspx");
    }
    protected void LinkAvailAuditors_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmAvailableAuditorReport.aspx");
    }
    protected void lnkCompany_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmCompanyInformationReport.aspx");
    }
}
