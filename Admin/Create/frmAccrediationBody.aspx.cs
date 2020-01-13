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

public partial class Admin_Create_frmAccrediationBody : System.Web.UI.Page
{
   
    AccrediationBodyBL accr = new AccrediationBodyBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false; 
            GridView1.DataSource = accr.GetAllAccrBodyTypes();
            GridView1.DataBind();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            accr.ACCRBODY_TYPE = txtBodyType.Text.Trim();
            accr.ACCRBODY_TYPE_DESC = txtDescription.Text.Trim();
            accr.InsertAccrBodyType();
            lblMsg.Text="Inserted...!";
        }
        catch (Exception ex)
        {
          lblMsg.Text=ex.Message.ToString();
        }

    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        try
        {
            txtDescription.Text = "";
            txtBodyType.Text = "";
            lblMsg.Text = "";
            txtBodyType.Focus();
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
            accr.ACCRBODY_TYPE_ID =Convert.ToInt32(ViewState["ID"].ToString());
            accr.ACCRBODY_TYPE = txtAccrType.Text.Trim();
            accr.ACCRBODY_TYPE_DESC = txtDesc.Text.Trim();
            accr.ModifyAccrBodyType();
            GridView1.DataSource = accr.GetAllAccrBodyTypes();
            GridView1.DataBind();
            lblUpdate.Text = "Updated...!";
           
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
 
    protected void btnNewEntry_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible=true;
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
            GridView1.DataSource = accr.GetAllAccrBodyTypes();
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
                accr.ACCRBODY_TYPE_ID =int.Parse(e.CommandArgument.ToString());
                ViewState["ID"] = int.Parse(e.CommandArgument.ToString());
                Panel2.Visible = true;
                DataSet ds=new DataSet();
                ds=accr.GetSelectedAccrBody();
                txtAccrType.Text = ds.Tables[0].Rows[0][0].ToString();
                txtDesc.Text = ds.Tables[0].Rows[0][1].ToString();
                GridView1.DataSource = accr.GetAllAccrBodyTypes();
                GridView1.DataBind();
            }
           
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
}
