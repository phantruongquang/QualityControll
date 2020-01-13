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
using System.Drawing;

public partial class Auditors_UserControls_HeaderUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnAuditors.BackColor = Color.DarkBlue;
            btnAuditors.ForeColor = Color.AliceBlue;
            btnAuditors.Font.Bold = true;
        }
    }
    protected void btnEnquiry_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Enquiry/frmEnquiryHome.aspx");
    }
    protected void btnQuotation_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Quotation/frmQuotationHomePage.aspx");

    }
    protected void btnAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/frmAdminHome.aspx");
    }
    protected void btnAudits_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Audits/frmAuditHome.aspx");
    }
    protected void btnAuditors_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Auditors/frmAuditorHome.aspx");
    }


    protected void btnReports_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Reports/frmReportsHome.aspx");
    }
}
