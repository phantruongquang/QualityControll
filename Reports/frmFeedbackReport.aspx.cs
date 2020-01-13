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

public partial class Reports_frmFeedbackReport : System.Web.UI.Page
{
    FeedBacktypeBL feed = new FeedBacktypeBL();
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
        ddlFeedBackType.DataSource = feed.GetAllFeedBackTypes();
        ddlFeedBackType.DataTextField = "FEEDBACKTYPE";
        ddlFeedBackType.DataValueField = "FEEDBACK_TYPE_ID";
        ddlFeedBackType.DataBind();
        ddlFeedBackType.Items.Insert(0, "---Select---");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            feed.FEEDBACKTYPEID = int.Parse(ddlFeedBackType.SelectedValue);
            GridView1.DataSource = feed.ShowFeedBackInfo();
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
            feed.FEEDBACKTYPEID = int.Parse(ddlFeedBackType.SelectedValue);
            GridView1.DataSource = feed.ShowFeedBackInfo();
            GridView1.DataBind();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
