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

public partial class Enquiry_Modify_frmModifyEnquiryCompanyInfo : System.Web.UI.Page
{
    //int index1, index2, index3;
    EnquiryCompanyBL enqcomp = new EnquiryCompanyBL();
    CertificateTypeBL cert = new CertificateTypeBL();
    AccrediationBodyBL accr = new AccrediationBodyBL();
    AuditFrequencyTypeBL freq = new AuditFrequencyTypeBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlFreqType.DataSource = freq.GetAllAuditFreqTypes();
            ddlFreqType.DataTextField = "auditfreq_type";
            ddlFreqType.DataValueField = "auditfreq_type_id";
            ddlFreqType.DataBind();
            //ddlAuditFreqType.Items.Insert(0, "---Select---");

            ddlAccerType.DataSource = accr.GetAllAccrBodyTypes();
            ddlAccerType.DataTextField = "accrbody_type";
            ddlAccerType.DataValueField = "accrbody_type_id";
            ddlAccerType.DataBind();
           // ddlAccrBody.Items.Insert(0, "---Select---");

            ddlCertType.DataSource = cert.GetAllCertTypes();
            ddlCertType.DataTextField = "cert_type";
            ddlCertType.DataValueField = "cert_type_id";
            ddlCertType.DataBind();
            //ddlCertificate.Items.Insert(0, "---Select---");
           
            
            enqcomp.EnquiryNo = Session["EnqNo"].ToString();
            DataSet ds = new DataSet();
            ds = enqcomp.ShowAllDetailOfEnquiry();
            txtEnqNo.Text = ds.Tables[0].Rows[0][0].ToString();
            txtRegisScope.Text = ds.Tables[0].Rows[0][1].ToString();
            ListItem li1 =ddlFreqType.Items.FindByValue(ds.Tables[0].Rows[0][2].ToString());
            if (li1 != null)
            {
                li1.Selected = true;
            }
           
            txtHearAbt.Text = ds.Tables[0].Rows[0][3].ToString();
            txtConsEng.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCompletedBy.Text = ds.Tables[0].Rows[0][5].ToString();
            txtDesignation.Text = ds.Tables[0].Rows[0][6].ToString();
            GMDatePicker1.Date =Convert.ToDateTime(ds.Tables[0].Rows[0][7].ToString());
            txtEnqtype.Text = ds.Tables[0].Rows[0][8].ToString();

            ListItem li2= ddlCertType.Items.FindByValue(ds.Tables[0].Rows[0][9].ToString());
            if (li2!=null)
            {
                li2.Selected = true;
            }

            ListItem li3 =ddlAccerType.Items.FindByValue(ds.Tables[0].Rows[0][10].ToString());
            if (li3 != null)
            {
                li3.Selected = true;
            }
          
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
    protected void btnModify_Click(object sender, EventArgs e)
    {
        //Enquiry Updation

        enqcomp.EnquiryNo = txtEnqNo.Text.Trim();
        enqcomp.RegistrationScope = txtRegisScope.Text.Trim();
        if (ddlFreqType.Items[0].Selected==true)
        {
            enqcomp.AuditFreqTypeId = Convert.ToInt32(ddlFreqType.SelectedItem.Value);
        }
        else
        {
            enqcomp.AuditFreqTypeId = Convert.ToInt32(ddlFreqType.SelectedItem.Value);
        }
        enqcomp.HearAbtAqa = txtHearAbt.Text.Trim();
        enqcomp.ConsEngdEarlier = txtConsEng.Text.Trim();
        enqcomp.CompletedBy = txtCompletedBy.Text.Trim();
        enqcomp.Designation = txtDesignation.Text.Trim();
        enqcomp.EnquiryDt = GMDatePicker1.Date.Date;
        enqcomp.EnquiryType = txtEnqtype.Text.Trim();
        if (ddlCertType.Items[0].Selected == true)
        {
            enqcomp.CertTypeId = Convert.ToInt32(ddlCertType.SelectedItem.Value);
        }
        else
        {
            enqcomp.CertTypeId = Convert.ToInt32(ddlCertType.SelectedItem.Value);
        }

        if (ddlAccerType.Items[0].Selected == true)
        {
            enqcomp.AccrBodyTypeId = Convert.ToInt32(ddlAccerType.SelectedItem.Value);
        }
        else
        {
            enqcomp.AccrBodyTypeId = Convert.ToInt32(ddlAccerType.SelectedItem.Value);
        }
     
        enqcomp.Confmandays = txtConformanceDay.Text.Trim();
        enqcomp.Survemandays = txtSurvilianceDay.Text.Trim();

       //Company Updation
        enqcomp.CompanyName = txtCompanyName.Text.Trim();
        enqcomp.MailingAddr1 = txtMailAddr1.Text.Trim();
        enqcomp.MailingAddr2 = txtMailAddr2.Text.Trim();
        enqcomp.ContactPerson = txtContactPerson.Text.Trim();
        enqcomp.Title = txtTitle.Text.Trim();
        enqcomp.CompSicCode = txtSiCCode.Text.Trim();
        enqcomp.IAFCode = txtIAFCode.Text.Trim();
        enqcomp.IndustryType = txtIndustryType.Text.Trim();
        enqcomp.AuditLocation = txtAuditLocation.Text.Trim();

        //Company Address Detail Updation
        DataSet ds = new DataSet();
        enqcomp.EnquiryNo = txtEnqNo.Text;
        enqcomp.CompanyName = txtCompanyName.Text;
        ds = enqcomp.GetCompanyId();
        enqcomp.Compid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
        enqcomp.Address1 = txtAddr1.Text.Trim();
        enqcomp.Address2 = txtAddr2.Text.Trim();
        enqcomp.City = txtCity.Text.Trim();
        enqcomp.State = txtState.Text.Trim();
        enqcomp.Country = txtCountry.Text.Trim();
        enqcomp.Email = txtEmail.Text.Trim();
        enqcomp.Telephone = txtPhone.Text.Trim();
        enqcomp.Fax = txtFax.Text.Trim();
        enqcomp.Mobile = txtMobile.Text.Trim();

        //Shift Updation
        TextBox t1, t2;
        foreach (GridViewRow gr in GridView1.Rows)
        {
            t1 = (TextBox)gr.FindControl("txt1");
            t2 = (TextBox)gr.FindControl("txt2");
            enqcomp.Shifttime1 = t1.Text;
            enqcomp.Totalemp1 =Convert.ToInt32(t2.Text);
            enqcomp.UpdateShiftDetail();
        }
        enqcomp.UpdateEnquiry();
        enqcomp.UpdateCompanyInfo();
        enqcomp.UpdateCompanyAddressDetail();
        lblMsg.Text = "Updated...!";

    }
}
