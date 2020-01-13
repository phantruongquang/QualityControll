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

public partial class Enquiry_Browse_frmEnqiryDetail : System.Web.UI.Page
{
    EnquiryCompanyBL enqcomp = new EnquiryCompanyBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = enqcomp.ShowEnquiryInfo();
            GridView1.DataBind();
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = enqcomp.ShowEnquiryInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Details")
            {
                Session["EnqNo"] = e.CommandArgument;
                Response.Redirect("~/Enquiry/Browse/frmShoqAllEnquiryDetial.aspx");
            }
        }
        catch (Exception)
        {
            
            throw;
        }

    }
}
