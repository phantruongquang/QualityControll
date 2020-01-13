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

public partial class Admin_UserControls_LeftWebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  
  
    protected void lnkHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/frmAdminHome.aspx");
    }
    protected void lnkLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
   
    protected void lnkUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmCreateUser.aspx");
    }
    protected void lnkAccreBody_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmAccrediationBody.aspx");
    }
    protected void lnkCertificate_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmCertificateType.aspx");
    }
    protected void lnkAuditFreq_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmAuditFrquency.aspx");
    }
    protected void lnkAuditor_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmAuditorType.aspx");
    }
    protected void lnkCommunication_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmCommunication.aspx");
    }
    protected void lnkFeedback_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmFeedbackType.aspx");
    }
    protected void lnkAudit_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Create/frmAuditType.aspx");

    }
}
