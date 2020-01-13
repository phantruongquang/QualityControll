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

public partial class Audits_Browse_frmRegistration : System.Web.UI.Page
{
    RegistrationInfoBL regis = new RegistrationInfoBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
        }

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = false;
            regis.Enqno = txtEnqNo.Text.Trim();
            regis.Quotationno = txtQuotationNo.Text.Trim();
            GridView1.DataSource = regis.ShowRegistration();
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
            Panel1.Visible=true;
      
            if (e.CommandName == "FileInfo")
        
            {
            regis.Fileno = e.CommandArgument.ToString();
            ViewState["FileNo"] = e.CommandArgument.ToString();
            DataSet ds = new DataSet();
            ds = regis.ShowFileInfo();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtFileNo.Text = ds.Tables[0].Rows[0][0].ToString();
                GMDatePicker1.Date = Convert.ToDateTime(ds.Tables[0].Rows[0][1].ToString());
                txtStorage.Text = ds.Tables[0].Rows[0][2].ToString();
                txtQuotNo.Text = ds.Tables[0].Rows[0][3].ToString();
                if (ds.Tables[0].Rows[0][4].ToString() == "y")
                {
                    chkCharges.Checked = true;
                    chkCharges.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    chkCharges.Checked = false;

                }
            }
            else
            {
                GMDatePicker1.Date = System.DateTime.Now.Date;
                txtStorage.Enabled = true;
                chkCharges.Enabled = true;
            }
            DataSet ds1 = new DataSet();
            regis.Fileno = txtFileNo.Text.Trim();
            ds1 = regis.Showregisno();
            regis.Regno =Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());
            ViewState["RegNo"] = ds1.Tables[0].Rows[0][0].ToString();
            DataSet ds2= new DataSet();
            ds2 = regis.GetSelectedCertInfo();
            txtCertificateNo.Text = ds2.Tables[0].Rows[0][0].ToString();
            GMDatePicker2.Date = Convert.ToDateTime(ds2.Tables[0].Rows[0][1].ToString());
            GMDatePicker3.Date = Convert.ToDateTime(ds2.Tables[0].Rows[0][2].ToString());
            if (ds2.Tables[0].Rows[0][3].ToString() == "y")
            {
                chkWiddrawn.Checked = true;
                chkWiddrawn.Text = ds2.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                chkWiddrawn.Checked = false;

            }
            if (ds2.Tables[0].Rows[0][4].ToString() == "y")
            {
                chkProbation.Checked = true;
                chkProbation.Text = ds2.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                chkProbation.Checked = false;

            }
        }
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void btnAuditInfo_Click(object sender, EventArgs e)
    {
        try
        {
            
             // string s=
            Session["FileNo"] = ViewState["FileNo"].ToString();
            Session["RegNo"]=Convert.ToInt32(ViewState["RegNo"].ToString());
            Response.Redirect("~/Audits/frmDocReviewInformation.aspx");
           
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnNewEntry_Click(object sender, EventArgs e)
    {
       
    }
}
