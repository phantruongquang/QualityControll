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

public partial class Auditors_Create_frmCreateAuditors : System.Web.UI.Page
{
    AuditorTypeBL auditor = new AuditorTypeBL();
    AuditorInformationBL auditorinfo = new AuditorInformationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlAuditorType.DataSource = auditor.GetAllAuditorTypes();
            ddlAuditorType.DataTextField = "AUDITOR_TYPE";
            ddlAuditorType.DataValueField = "AUDITOR_TYPE_ID";
            ddlAuditorType.DataBind();
            ddlAuditorType.Items.Insert(0, "---Select---");
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            auditorinfo.AUDITORTYPE = int.Parse(ddlAuditorType.SelectedValue);
            auditorinfo.AUDITORNAME = txtAuditorName.Text.Trim();
            auditorinfo.QUALI = txtQualification.Text.Trim();
            auditorinfo.EXPE = txtQualification.Text.Trim();
            auditorinfo.ICRDETAILS = txtIRCANo.Text.Trim();
            auditorinfo.LACERTNO = txtLacertNo.Text.Trim();
            auditorinfo.LADATE = GMDatePicker1.Date.Date;
            auditorinfo.SICCODE = txtSICCode.Text.Trim();
            auditorinfo.ADDRESS1 = txtAddr1.Text.Trim();
            auditorinfo.ADDRESS2 = txtAddr2.Text.Trim();
            auditorinfo.CITY = txtCity.Text.Trim();
            auditorinfo.STATE = txtState.Text.Trim();
            auditorinfo.COUNTRY = txtCountry.Text.Trim();
            auditorinfo.PHONE = txtPhone.Text.Trim();
            auditorinfo.MOBILE = txtMobile.Text.Trim();
            auditorinfo.FAX = txtFax.Text.Trim();
            auditorinfo.EMAIL = txtEmail.Text.Trim();
            auditorinfo.InsertAuditor();
            lblMsg.Text = "Inserted...!";

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }
    }
}
