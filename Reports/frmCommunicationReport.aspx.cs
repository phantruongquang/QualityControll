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

public partial class Reports_frmCommunicationReport : System.Web.UI.Page
{
    CommunicationTypeBL comm = new CommunicationTypeBL();
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
        ddlCommType.DataSource = comm.GetAllCommTypes();
        ddlCommType.DataTextField = "commtype";
        ddlCommType.DataValueField = "commtypeid";
        ddlCommType.DataBind();
        ddlCommType.Items.Insert(0, "---Select---");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            comm.COMMTYPEID = int.Parse(ddlCommType.SelectedValue);
            GridView1.DataSource = comm.ShowCommunicationInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        BindData();       
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            comm.COMMTYPEID = int.Parse(ddlCommType.SelectedValue);
            GridView1.DataSource = comm.ShowCommunicationInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
