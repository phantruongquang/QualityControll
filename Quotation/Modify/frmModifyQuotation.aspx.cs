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

public partial class Quotation_Modify_frmModifyQuotation : System.Web.UI.Page
{
    QuotationBL quot = new QuotationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            quot.QUOTATIONNO = Session["Quot"].ToString();
            DataSet ds = new DataSet();
            ds = quot.ShowQuotationInfo();
            lblQuotNo.Text = ds.Tables[0].Rows[0][0].ToString();
            lblEnqno.Text = ds.Tables[0].Rows[0][1].ToString();
            lblIsApproved.Text = ds.Tables[0].Rows[0][2].ToString();
            GMDatePicker1.Date =Convert.ToDateTime(ds.Tables[0].Rows[0][3].ToString());
            GMDatePicker2.Date = Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString());

            GridView1.DataSource = quot.ShowQuotationFeesInfo();
            GridView1.DataBind();
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            Label l;
            TextBox t1, t2;
            quot.QUOTATIONNO = lblQuotNo.Text;
            quot.QUOTATIONDT = GMDatePicker1.Date.Date;
            quot.APPROVEDDATE = GMDatePicker2.Date.Date;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                l = (Label)gr.FindControl("lbl1");
                quot.AUDIT_TYPE_ID = Convert.ToInt32(l.Text);
                t1 = (TextBox)gr.FindControl("txt1");
                t2 = (TextBox)gr.FindControl("txt2");
                quot.AUDITFEESRS = Convert.ToInt32(t1.Text);
                quot.AUDITFEESDLR = Convert.ToInt32(t2.Text);
                quot.ModifyQuotationFees();
            }
            quot.ModifyQuotationDetail();
          
            lblMsg.Text = "Updated...!";

        }
        catch (Exception ex)
        {

            lblMsg.Text = ex.Message.ToString();
        }

    }
}
