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

public partial class Enquiry_Create_frmCompanyInformation : System.Web.UI.Page
{
    EnquiryCompanyBL enquiry = new EnquiryCompanyBL();
    AuditFrequencyTypeBL freq = new AuditFrequencyTypeBL();
    AccrediationBodyBL accr = new AccrediationBodyBL();
    CertificateTypeBL cert = new CertificateTypeBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlAuditFreqType.DataSource = freq.GetAllAuditFreqTypes();
            ddlAuditFreqType.DataTextField = "auditfreq_type";
            ddlAuditFreqType.DataValueField = "auditfreq_type_id";
            ddlAuditFreqType.DataBind();
            ddlAuditFreqType.Items.Insert(0, "---Select---");

            ddlAccrBody.DataSource = accr.GetAllAccrBodyTypes();
            ddlAccrBody.DataTextField = "accrbody_type";
            ddlAccrBody.DataValueField = "accrbody_type_id";
            ddlAccrBody.DataBind();
            ddlAccrBody.Items.Insert(0, "---Select---");

            ddlCertificate.DataSource = cert.GetAllCertTypes();
            ddlCertificate.DataTextField = "cert_type";
            ddlCertificate.DataValueField = "cert_type_id";
            ddlCertificate.DataBind();
            ddlCertificate.Items.Insert(0, "---Select---");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            enquiry.ExistingEnquiryNo = txtEnqNo.Text.Trim();
            enquiry.EnquiryNo = txtEnqNo.Text.Trim();
            enquiry.RegistrationScope = txtRegisScope.Text.Trim();
            enquiry.AuditFreqTypeId = int.Parse(ddlAuditFreqType.SelectedValue);
            enquiry.HearAbtAqa = txtHearAbt.Text.Trim();
            enquiry.ConsEngdEarlier = txtConsEng.Text.Trim();
            enquiry.CompletedBy = txtCompletedBy.Text.Trim();
            enquiry.Designation = txtDesignation.Text.Trim();
            enquiry.EnquiryDt = GMDatePicker1.Date.Date;
            enquiry.EnquiryType = txtEnqtype.Text.Trim();
            enquiry.CertTypeId = int.Parse(ddlCertificate.SelectedValue);
            enquiry.AccrBodyTypeId = int.Parse(ddlAccrBody.SelectedValue);
            enquiry.CompanyName = txtCompanyName.Text.Trim();
            enquiry.MailingAddr1 = txtMailAddr1.Text.Trim();
            enquiry.MailingAddr2 = txtMailAddr2.Text.Trim();
            enquiry.ContactPerson = txtContactPerson.Text.Trim();
            enquiry.Title = txtTitle.Text.Trim();
            enquiry.CompSicCode = txtSiCCode.Text.Trim();
            enquiry.IAFCode = txtIAFCode.Text.Trim();
            enquiry.IndustryType = txtIndustryType.Text.Trim();
            enquiry.AuditLocation = txtAuditLocation.Text.Trim();
            enquiry.Address1 = txtAddr1.Text.Trim();
            enquiry.Address2 = txtAddr2.Text.Trim();
            enquiry.City = txtCity.Text.Trim();
            enquiry.State = txtState.Text.Trim();
            enquiry.Country = txtCountry.Text.Trim();
            enquiry.Email = txtEmail.Text.Trim();
            enquiry.Telephone = txtPhone.Text.Trim();
            enquiry.Fax = txtFax.Text.Trim();
            enquiry.Mobile = txtMobile.Text.Trim();
            enquiry.Is_active = Convert.ToChar('y');
            enquiry.Shiftid1 = 1;
            enquiry.Shifttime1 = txtTime1.Text.Trim();
            enquiry.Totalemp1 = int.Parse(txtEmpNo1.Text.Trim());
            enquiry.Shiftid2 = 2;
            enquiry.Shifttime2 = txtTime2.Text.Trim();
            enquiry.Totalemp2 =int.Parse(txtEmpNo2.Text.Trim());
            enquiry.Confmandays = txtConformanceDay.Text.Trim();
            enquiry.Survemandays = txtSurvilianceDay.Text.Trim();
            enquiry.EnquiryInsertion();
            lblMsg.Text = "Inserted...!";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
           
        }

    }
}
