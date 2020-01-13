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

public partial class Enquiry_Create_frmCreateEnquiry : System.Web.UI.Page
{
    //EnquiryBL enquiry = new EnquiryBL();
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
        //try
        //{
        //    enquiry.ENQUIRY_NO = txtEnqNo.Text.Trim();
        //    enquiry.REGISTRATIONSCOPE = txtRegisScope.Text.Trim();
        //    enquiry.AUDITFREQ_TYPE_ID = int.Parse(ddlAuditFreqType.SelectedValue);
        //    enquiry.HEARABTAQA = txtHearAbout.Text.Trim();
        //    enquiry.CONSENGDEARLIER = txtConsenGd.Text.Trim();
        //    enquiry.COMPLETEDBY = txtCompiledBy.Text.Trim();
        //    enquiry.DESIGNATION = txtDesignation.Text.Trim();
        //    enquiry.ENQUIRYDT = GMDatePicker1.Date.Date;
        //    enquiry.ENQUIRYTYPE = txtEnqType.Text.Trim();
        //    enquiry.CERT_TYPE_ID = int.Parse(ddlCertificate.SelectedValue);
        //    enquiry.ACCRBODY_TYPE_ID = int.Parse(ddlAccrBody.SelectedValue);
        //    enquiry.CONF_MANDAYS = txtConformanceDay.Text.Trim();
        //    enquiry.SURVE_MANDAYS = txtSurvilianceDay.Text.Trim();
        //    enquiry.InsertEnquiry();
            lblMsg.Text = "Inserted...!";
        //}
        //catch (Exception)
        //{
            
        //    throw;
        //}
    }
    protected void lnkCompany_Click(object sender, EventArgs e)
    {
        //Session["EnqNo"] = txtEnqNo.Text.Trim();
        //Response.Redirect("~/Enquiry/Create/frmCompanyInformation.aspx");
    }
}
