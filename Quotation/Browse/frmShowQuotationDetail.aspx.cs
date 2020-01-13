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

public partial class Quotation_Browse_frmShowQuotationDetail : System.Web.UI.Page
{
    QuotationBL quot = new QuotationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = quot.ShowAllQuotation();
            GridView1.DataBind();
            Panel1.Visible = false;
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = quot.ShowAllQuotation();
            GridView1.DataBind();
            Panel1.Visible = false;
           Label l;
           foreach (GridViewRow gr in GridView1.Rows)
           {
               l = (Label)gr.FindControl("lbl");
               quot.QUOTATIONNO = l.Text;
           }
        }
        catch (Exception)
        {
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Detail")
            {
                quot.QUOTATIONNO = e.CommandArgument.ToString();
                DataSet ds = new DataSet();
                ds = quot.ShowQuotationInfo();
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
                Label5.Text = ds.Tables[0].Rows[0][4].ToString();
                GridView2.DataSource = quot.ShowQuotationFeesInfo();
                GridView2.DataBind();
                Panel1.Visible = true;
               
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}
