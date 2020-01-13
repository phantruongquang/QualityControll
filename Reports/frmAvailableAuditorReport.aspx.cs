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

public partial class Reports_frmAvailableAuditorReport : System.Web.UI.Page
{
    AuditorInformationBL auditor = new AuditorInformationBL();
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
            auditor.LADATE = GMDatePicker1.Date;
            auditor.SICCODE = txtSICCODE.Text.Trim();
            GridView2.DataSource = auditor.ShowAvailableAuditor();
            GridView2.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView2.PageIndex = e.NewPageIndex;
            Panel1.Visible = true;
            auditor.LADATE = GMDatePicker1.Date;
            auditor.SICCODE = txtSICCODE.Text.Trim();
            GridView2.DataSource = auditor.ShowAvailableAuditor();
            GridView2.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        txtSICCODE.Text = "";
    }
}
