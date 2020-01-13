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

public partial class Auditors_Modify_frmSearchAuditorsForModification : System.Web.UI.Page
{
    AuditorTypeBL auditor = new AuditorTypeBL();
    AuditorInformationBL auditorinfo = new AuditorInformationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlAuditorType.DataSource = auditor.GetAllAuditorTypes();
            ddlAuditorType.DataTextField = "AUDITOR_TYPE";
            ddlAuditorType.DataValueField = "AUDITOR_TYPE_ID";
            ddlAuditorType.DataBind();
            ddlAuditorType.Items.Insert(0, "---Select---");
        }

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            auditorinfo.AUDITORTYPE = int.Parse(ddlAuditorType.SelectedValue);
            GridView1.DataSource = auditorinfo.ShowDetailByAuditorTypeId();
            GridView1.DataBind();

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
            GridView1.PageIndex = e.NewPageIndex;
            auditorinfo.AUDITORTYPE = int.Parse(ddlAuditorType.SelectedValue);
            GridView1.DataSource = auditorinfo.ShowDetailByAuditorTypeId();
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
                Session["AuditorId"] = e.CommandArgument;
                Response.Redirect("~/Auditors/Modify/frmModifyAuditorDetails.aspx");
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
