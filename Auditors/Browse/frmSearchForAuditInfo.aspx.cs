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

public partial class Auditors_Browse_frmSearchForAuditInfo : System.Web.UI.Page
{
    AuditorInformationBL auditorinfo = new AuditorInformationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = auditorinfo.ShowAuditorInfo();
            GridView1.DataBind();
        }

    }
   
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = auditorinfo.ShowAuditorInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Details")
        {
            Session["AuditorId"] = e.CommandArgument;
            Response.Redirect("~/Auditors/Browse/frmAuditorDetailInformation.aspx");
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
            auditorinfo.AUDITORID = Convert.ToInt32(lblAUDITORID.Text);
            DataSet dstemp;
            dstemp = auditorinfo.ShowSICCODE();
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
