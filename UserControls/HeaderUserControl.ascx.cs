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

public partial class UserControls_HeaderUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEnquiry_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Enquiry/frmEnquiryHome.aspx");
    }
    protected void btnQuotation_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Quotation/frmQuotationHomePage.aspx");

    }
}
