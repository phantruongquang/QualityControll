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

public partial class Enquiry_EnquiryMasterPage : System.Web.UI.MasterPage
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
        Response.Redirect("~/Enquiry/Create/frmCreateEnqiry.aspx");
    }
   
}
