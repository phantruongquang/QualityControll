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

public partial class Enquiry_UserControls_LeftWebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkBrowse_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Enquiry/Browse/frmEnqiryDetail.aspx");
    }
    protected void lnkCreate_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Enquiry/Create/frmEnquiryCompanyInformation.aspx");
    }
    protected void lnkHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Enquiry/frmEnquiryHome.aspx");
    }
    protected void lnkLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
    protected void lnkModify_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Enquiry/Modify/frmSearchEnquiryCompnay.aspx");
    }
}
