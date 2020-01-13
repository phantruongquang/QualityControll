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

public partial class Quotation_Modify_frmQuotationDetail : System.Web.UI.Page
{
    QuotationBL quot = new QuotationBL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            quot.QUOTATIONNO = txtQuotationNo.Text.Trim();
            GridView1.DataSource = quot.ShowQuotationInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Modify")
        {
            Session["Quot"]= e.CommandArgument;
            Response.Redirect("~/Quotation/Modify/frmModifyQuotation.aspx");
            
        }
    }
}
