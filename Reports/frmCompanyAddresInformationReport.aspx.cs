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

public partial class Reports_frmCompanyAddresInformationReport : System.Web.UI.Page
{
    EnquiryCompanyBL enqcomp = new EnquiryCompanyBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataSet ds2 = new DataSet();
            enqcomp.EnquiryNo = Session["EnqNo"].ToString();
            enqcomp.CompanyName = Session["CompName"].ToString();
            ds2 = enqcomp.GetCompanyId();

            txtEnqNo.Text = enqcomp.EnquiryNo;
            txtCompanyName.Text = enqcomp.CompanyName;
            enqcomp.Compid = int.Parse(ds2.Tables[0].Rows[0][0].ToString());
            DataSet ds3 = new DataSet();
            ds3 = enqcomp.ShowCompAddressDetail();
            txtAddr1.Text = ds3.Tables[0].Rows[0][0].ToString();
            txtAddr2.Text = ds3.Tables[0].Rows[0][1].ToString();
            txtCity.Text = ds3.Tables[0].Rows[0][2].ToString();
            txtState.Text = ds3.Tables[0].Rows[0][3].ToString();
            txtCountry.Text = ds3.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds3.Tables[0].Rows[0][5].ToString();
            txtPhone.Text = ds3.Tables[0].Rows[0][6].ToString();
            txtFax.Text = ds3.Tables[0].Rows[0][7].ToString();
            txtMobile.Text = ds3.Tables[0].Rows[0][8].ToString();
        }
    }
}
