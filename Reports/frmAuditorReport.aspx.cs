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

public partial class Reports_frmAuditorReprt : System.Web.UI.Page
{
    AuditorInformationBL auditor = new AuditorInformationBL();
    AuditorTypeBL type = new AuditorTypeBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }

    }
    public void BindData()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        ddlAuditorType.DataSource = type.GetAllAuditorTypes();
        ddlAuditorType.DataTextField = "AUDITOR_TYPE";
        ddlAuditorType.DataValueField = "AUDITOR_TYPE_ID";
        ddlAuditorType.DataBind();
        ddlAuditorType.Items.Insert(0, "---Select---");
    
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (ddlStatus.SelectedIndex == 0)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            auditor.AUDITORTYPE = Convert.ToInt32(ddlAuditorType.SelectedValue);
            auditor.AUDITORNAME = txtAuditorName.Text.Trim();
            GridView1.DataSource = auditor.ShowAuditorPersonalInfo();
            GridView1.DataBind();
        }
        if(ddlStatus.SelectedIndex==1)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            auditor.AUDITORTYPE = Convert.ToInt32(ddlAuditorType.SelectedValue);
            auditor.AUDITORNAME = txtAuditorName.Text.Trim();
            GridView2.DataSource = auditor.ShowAuditorAddressInfo();
            GridView2.DataBind();
        }
    }
   
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            BindData();
           
            txtAuditorName.Text = "";
          

        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            GridView1.PageIndex = e.NewPageIndex;
            auditor.AUDITORTYPE = Convert.ToInt32(ddlAuditorType.SelectedValue);
            auditor.AUDITORNAME = txtAuditorName.Text.Trim();
            GridView1.DataSource = auditor.ShowAuditorPersonalInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        Label lblAUDITORID;
        lblAUDITORID = (Label)e.Row.FindControl("lblAUDITORID");
        Label lbl3SICCODE;
        lbl3SICCODE = (Label)e.Row.FindControl("lbl3SICCODE");
        if (lblAUDITORID != null && lblAUDITORID.Text != "")
        {
            auditor.AUDITORID = Convert.ToInt32(lblAUDITORID.Text);
            DataSet dstemp;
            dstemp = auditor.ShowSICCODE();
            DataRowCollection drc = dstemp.Tables[0].Rows;
            string strSICCODE = string.Empty;
            if (drc.Count > 0)
            {
                foreach (DataRow dr in drc)
                {
                    strSICCODE += dr[0].ToString() + ",";
                }
                strSICCODE = strSICCODE.Remove(strSICCODE.Length - 1, 1);
                lbl3SICCODE.Text = strSICCODE;
            }
            else
            {
                lbl3SICCODE.Text = "N/A";
            }
        }
    }
}
