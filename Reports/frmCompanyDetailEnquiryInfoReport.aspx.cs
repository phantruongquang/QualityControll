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

public partial class Reports_frmCompanyDetailEnquiryInfoReport : System.Web.UI.Page
{
    EnquiryCompanyBL enqcomp = new EnquiryCompanyBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            enqcomp.EnquiryNo = Session["EnqNo"].ToString();
            DataSet ds = new DataSet();
            ds = enqcomp.ShowAllDetailOfEnquiry();
            txtEnqNo.Text = ds.Tables[0].Rows[0][0].ToString();
            txtRegisScope.Text = ds.Tables[0].Rows[0][1].ToString();
            txtFreqType.Text = ds.Tables[0].Rows[0][2].ToString();
            txtHearAbt.Text = ds.Tables[0].Rows[0][3].ToString();
            txtConsEng.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCompletedBy.Text = ds.Tables[0].Rows[0][5].ToString();
            txtDesignation.Text = ds.Tables[0].Rows[0][6].ToString();
            txtEnqDate.Text = ds.Tables[0].Rows[0][7].ToString();
            txtEnqtype.Text = ds.Tables[0].Rows[0][8].ToString();
            txtCertType.Text = ds.Tables[0].Rows[0][9].ToString();
            txtAccerType.Text = ds.Tables[0].Rows[0][10].ToString();
            txtConformanceDay.Text = ds.Tables[0].Rows[0][11].ToString();
            txtSurvilianceDay.Text = ds.Tables[0].Rows[0][12].ToString();

            DataSet ds1 = new DataSet();
            ds1 = enqcomp.ShowCompanyDetail();
            txtCompanyName.Text = ds1.Tables[0].Rows[0][0].ToString();
            txtMailAddr1.Text = ds1.Tables[0].Rows[0][1].ToString();
            txtMailAddr2.Text = ds1.Tables[0].Rows[0][2].ToString();
            txtContactPerson.Text = ds1.Tables[0].Rows[0][3].ToString();
            txtTitle.Text = ds1.Tables[0].Rows[0][4].ToString();
            txtSiCCode.Text = ds1.Tables[0].Rows[0][5].ToString();
            txtIAFCode.Text = ds1.Tables[0].Rows[0][6].ToString();
            txtIndustryType.Text = ds1.Tables[0].Rows[0][7].ToString();
            txtAuditLocation.Text = ds1.Tables[0].Rows[0][8].ToString();

            DataSet ds2 = new DataSet();
            enqcomp.EnquiryNo = txtEnqNo.Text;
            enqcomp.CompanyName = txtCompanyName.Text;
            ds2 = enqcomp.GetCompanyId();

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

            DataSet ds4 = new DataSet();
            ds4 = enqcomp.ShowShiftDetail();
            GridView1.DataSource = enqcomp.ShowShiftDetail();
            GridView1.DataBind();
        }
    }
}
