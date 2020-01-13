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

public partial class Admin_Create_frmCertificateType : System.Web.UI.Page
{
    CertificateTypeBL cert = new CertificateTypeBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            GridView1.DataSource = cert.GetAllCertTypes();
            GridView1.DataBind();
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            cert.CERT_TYPE = txtCertificateType.Text.Trim();
            cert.CERT_TYPE_DESC = txtDescription.Text.Trim();
            cert.InsertCertificateType();
            lblMsg.Text = "Inserted...!";
            GridView1.DataSource = cert.GetAllCertTypes();
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }

    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        try
        {
            txtDescription.Text = "";
            txtCertificateType.Text = "";
            lblMsg.Text = "";
            txtCertificateType.Focus();
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
        cert.CERT_TYPE_ID=Convert.ToInt32(ViewState["ID"].ToString());
        cert.CERT_TYPE = txtCertType.Text.Trim();
        cert.CERT_TYPE_DESC = txtDesc.Text.Trim();
        cert.ModifyCertType();
        lblUpdate.Text = "Updated...!";
        GridView1.DataSource = cert.GetAllCertTypes();
        GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblUpdate.Text = ex.Message.ToString();
        }

    }
    protected void btnCancelUpdate_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = cert.GetAllCertTypes();
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
                Panel2.Visible = true;
                cert.CERT_TYPE_ID = Convert.ToInt32(e.CommandArgument.ToString());
                ViewState["ID"] = Convert.ToInt32(e.CommandArgument.ToString());
                DataSet ds=new DataSet();
                ds=cert.GetSelectedCertType();
                txtCertType.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDesc.Text = ds.Tables[0].Rows[0][2].ToString();
            }
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void btnNewEntry_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
}
