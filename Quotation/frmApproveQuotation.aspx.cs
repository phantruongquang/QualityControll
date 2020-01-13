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

public partial class Quotation_frmApproveQuotation : System.Web.UI.Page
{
    QuotationBL quot = new QuotationBL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            quot.QUOTATIONNO = txtEnqno.Text.Trim();
            DataSet ds = new DataSet();
            ds = quot.ShowQuotationInfo();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            Button btn;
            foreach (GridViewRow gr in GridView1.Rows)
            {                
                btn = (Button)gr.FindControl("btn");
                if (ds.Tables[0].Rows[0][2].ToString() == "n")
                {
                    btn.Visible = true;

                }
                else
                {
                    btn.Visible = false;
                }

            }
            
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
            if (e.CommandName == "Approve")
            {
                quot.UpdateQuotationApproval(txtEnqno.Text);
                quot.QUOTATIONNO = txtEnqno.Text.Trim();
                DataSet ds = new DataSet();
                ds = quot.ShowQuotationInfo();
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                Button btn;
                foreach (GridViewRow gr in GridView1.Rows)
                {
                    btn = (Button)gr.FindControl("btn");
                    if (ds.Tables[0].Rows[0][2].ToString() == "n")
                    {
                        btn.Visible = true;

                    }
                    else
                    {
                        btn.Visible = false;
                    }

                }
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
