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

public partial class Reports_frmCompanyInformationReport : System.Web.UI.Page
{
    EnquiryCompanyBL enqcomp = new EnquiryCompanyBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
        }

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (ddlReportype.SelectedIndex == 0)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            enqcomp.CompanyName = txtCompName.Text.Trim();
            enqcomp.CompSicCode = txtSICCode.Text.Trim();
            GridView1.DataSource = enqcomp.ShowCompanyEnquiryDetail();
            GridView1.DataBind();
        
        }
        else if (ddlReportype.SelectedIndex == 1)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            enqcomp.CompanyName = txtCompName.Text.Trim();
            enqcomp.CompSicCode = txtSICCode.Text.Trim();
            GridView2.DataSource = enqcomp.ShowCompanyQuotationInfo();
            GridView2.DataBind();
        
        }
         else if (ddlReportype.SelectedIndex == 2)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
            enqcomp.CompanyName = txtCompName.Text.Trim();
            enqcomp.CompSicCode = txtSICCode.Text.Trim();
            GridView3.DataSource = enqcomp.ShowCompAddDetail();
            GridView3.DataBind();
        
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        txtCompName.Text = "";
        txtSICCode.Text = "";
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        if (ddlReportype.SelectedIndex == 0)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            enqcomp.CompanyName = txtCompName.Text.Trim();
            enqcomp.CompSicCode = txtSICCode.Text.Trim();
            GridView1.DataSource = enqcomp.ShowCompanyEnquiryDetail();
            GridView1.DataBind();

        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Details")
            {
                Session["EnqNo"] = e.CommandArgument.ToString();
                Response.Redirect("~/Reports/frmCompanyDetailEnquiryInfoReport.aspx");
            }
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
             if (ddlReportype.SelectedIndex == 1)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            enqcomp.CompanyName = txtCompName.Text.Trim();
            enqcomp.CompSicCode = txtSICCode.Text.Trim();
            GridView2.DataSource = enqcomp.ShowCompanyQuotationInfo();
            GridView2.DataBind();
        
        }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView3.PageIndex = e.NewPageIndex;
            if (ddlReportype.SelectedIndex == 2)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = true;
                enqcomp.CompanyName = txtCompName.Text.Trim();
                enqcomp.CompSicCode = txtSICCode.Text.Trim();
                GridView3.DataSource = enqcomp.ShowCompAddDetail();
                GridView3.DataBind();

            }
        }
        catch (Exception)
        {
            
            throw;
        }
       
    }
    protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Address")
            {
                Session["EnqNo"] = e.CommandArgument.ToString();
                Session["CompName"] = txtCompName.Text.Trim();
                Response.Redirect("~/Reports/frmCompanyAddresInformationReport.aspx");
            }
        }
        catch (Exception)
        {

            throw;
        }

    }
}
