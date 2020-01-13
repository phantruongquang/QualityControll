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

public partial class Reports_frmEnquiryReportByDate : System.Web.UI.Page
{
    EnquiryCompanyBL enq = new EnquiryCompanyBL();
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
            enq.Date1 = GMDatePicker1.Date;
            enq.Date2 = GMDatePicker2.Date;
            GridView2.DataSource = enq.ShowEnquiryByDates();
            GridView2.DataBind();

        }
        catch (Exception)
        {
            
            throw;
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = false;
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
            enq.Date1 = GMDatePicker1.Date;
            enq.Date2 = GMDatePicker2.Date;
            GridView2.DataSource = enq.ShowEnquiryByDates();
            GridView2.DataBind();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
