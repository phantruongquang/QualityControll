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

public partial class Admin_Create_frmCommunication : System.Web.UI.Page
{
    CommunicationTypeBL comm = new CommunicationTypeBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            GridView1.DataSource = comm.GetAllCommTypes();
            GridView1.DataBind();
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = comm.GetAllCommTypes();
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
                comm.COMMTYPEID = Convert.ToInt32(e.CommandArgument.ToString());
                ViewState["ID"] = Convert.ToInt32(e.CommandArgument.ToString());
                DataSet ds = new DataSet();
                ds = comm.GetSelectedCommType();
                txtCommType.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDesc.Text = ds.Tables[0].Rows[0][2].ToString();
            }
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
            comm.COMMTYPEID = Convert.ToInt32(ViewState["ID"].ToString());
            comm.COMMTYPE = txtCommType.Text.Trim();
            comm.COMMDESC = txtDesc.Text.Trim();
            comm.ModifyCommType();
            lblUpdate.Text = "Updated...!";
            GridView1.DataSource = comm.GetAllCommTypes();
            GridView1.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void btnCancelUpdate_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        lblUpdate.Text = "";
    }
    protected void btnNewEntry_Click(object sender, EventArgs e)
    {
        Panel1.Visible =true;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            comm.COMMTYPE = txtCommunicationType.Text.Trim();
            comm.COMMDESC = txtDescription.Text.Trim();
            comm.InsertCommunicationType();
            lblMsg.Text = "Inserted...!";
            GridView1.DataSource = comm.GetAllCommTypes();
            GridView1.DataBind();

        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        txtDescription.Text = "";
        txtCommunicationType.Text = "";
        lblMsg.Text = "";
        txtCommunicationType.Focus();

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;

    }
}
