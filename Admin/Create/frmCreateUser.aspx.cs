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

public partial class Admin_Create_frmCreateUser : System.Web.UI.Page
{
    UserLoginBL login = new UserLoginBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            GridView1.DataSource = login.GetAllUsers();
            GridView1.DataBind();
            ddlUser.DataSource = login.ShowUser();
            ddlUser.DataTextField = "RoleName";
            ddlUser.DataValueField = "RoleId";
            ddlUser.DataBind();
            ddlUser.Items.Insert(0, "---Select---");
        }

    }
    protected void btnNewEntry_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            lblMsg.Text = "";
            lblUpdate.Text = "";
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtUName.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                login.USERNAME = txtUName.Text.Trim();
                if (login.ChekUserAvailable() == true)
                {
                    lblMsg.Text = "User Name Already Exists...!";
                    txtUName.Focus();
                }
                else
                {
                    login.PASSWORD = txtPassword.Text.Trim();
                    login.ROLEID = int.Parse(ddlUser.SelectedValue);
                    login.InsertUser();
                    lblMsg.Text = "User Added...!";
                    GridView1.DataSource = login.GetAllUsers();
                    GridView1.DataBind();
                }
            }
            else
            {
                lblMsg.Text = "Plz Enter User Name or Password...!";
            }

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = login.GetAllUsers();
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
                login.USERID =int.Parse(e.CommandArgument.ToString());
                Panel2.Visible = true;
                DataSet ds=new DataSet();
                ds=login.GetSelectedUser();
                txtUser.Text = ds.Tables[0].Rows[0][0].ToString();
                txtPwd.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            if(e.CommandName=="Delete")
                Panel2.Visible = false;
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnCancelUpdate_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
         try
         {    
        login.USERNAME = txtUser.Text.Trim();
        login.PASSWORD = txtPwd.Text.Trim();
        login.ModifyUser();
        lblUpdate.Text = "User Updated...!";  
        }
        catch (Exception ex)
        {
            lblUpdate.Text = ex.Message.ToString();
        }
    }
       protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label l;
        foreach (GridViewRow gr in GridView1.Rows)
        {
            if (gr.RowIndex == e.RowIndex)
            {
                l = (Label)gr.FindControl("lbl2");
                login.USERNAME = l.Text;
                login.DeleteUser();
                GridView1.DataSource = login.GetAllUsers();
                GridView1.DataBind();
            }
        }

    }
}
