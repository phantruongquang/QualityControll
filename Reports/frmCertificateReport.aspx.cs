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

public partial class Reports_frmCertificateReport : System.Web.UI.Page
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
            Panel1.Visible = true;
            regis.Certificateno = txtCertNo.Text.Trim();
            regis.Fileno = txtFileNo.Text.Trim();
            if (ddlStatus.SelectedIndex == 0)
            {
                regis.Iswithdrawn = 'n';
            }
            else if (ddlStatus.SelectedIndex == 1)
            {
                regis.Isprobation = 'y';
            }
            GridView1.DataSource = regis.ShowCertificateInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtFileNo.Text = "";
        txtCompName.Text = "";
        txtCertNo.Text = "";
        Panel1.Visible = false;
        
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
              GridView1.DataSource = regis.ShowCertificateInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
