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

public partial class Enquiry_Modify_frmSearchEnquiryCompnay : System.Web.UI.Page
{
    EnquiryCompanyBL enqcomp = new EnquiryCompanyBL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            enqcomp.EnquiryNo = txtEnqNo.Text.Trim();
            GridView1.DataSource = enqcomp.ShowEnquiryInfoByEnqNo();
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
            if (e.CommandName == "Modify")
            {
                Session["EnqNo"] = e.CommandArgument;
                Response.Redirect("~/Enquiry/Modify/frmModifyEnquiryCompanyInfo.aspx");
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
