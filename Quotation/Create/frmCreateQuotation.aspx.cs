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

public partial class Quotation_Create_frmCreateQuotation : System.Web.UI.Page
{
    AuditTypeBL audit = new AuditTypeBL();
    EnquiryCompanyBL enquiry = new EnquiryCompanyBL();
    QuotationBL quot = new QuotationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            ddlAudit.DataSource = audit.GetAllAuditTypes();
            ddlAudit.DataTextField = "audit_type";
            ddlAudit.DataValueField = "AUDIT_TYPE_ID";
            ddlAudit.DataBind();
            ddlAudit.Items.Insert(0, "---Select---");

            ddlEnqNo.DataSource = enquiry.GetAllEnquiryNo();
            ddlEnqNo.DataTextField = "ENQUIRY_NO";
            ddlEnqNo.DataBind();
            ddlEnqNo.Items.Insert(0, "---Select---");
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            quot.QUOTATIONNO = txtQuotNo.Text.Trim();
            quot.ENQUIRY_NO = ddlEnqNo.SelectedItem.Text;
            quot.QUOTATIONDT = GMDatePicker1.Date.Date;
            if (radYes.Checked)
                quot.IS_APPROVED =Convert.ToChar('y');
            else if (radNo.Checked)
                quot.IS_APPROVED =Convert.ToChar('n');
            quot.APPROVEDDATE = GMDatePicker2.Date.Date;
            quot.QuotationDetailsInsert();
            lblMsg.Text = "Inserted...!";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }

    }
    protected void btnQuotation_Click(object sender, EventArgs e)
    {
        try
        {
            Panel1.Visible = true;
            lblMsg.Text = "";
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            quot.QUOTATIONNO = txtQuotNo.Text.Trim();
            quot.AUDIT_TYPE_ID = int.Parse(ddlAudit.SelectedValue);
            quot.AUDITFEESRS = Convert.ToInt32(txtAuditFeeRs.Text.Trim());
            quot.AUDITFEESDLR = Convert.ToInt32(txtFeeDolor.Text.Trim());
            quot.QuotationFeesDetailsInsert();
            lblMsg.Text = "Inserted...!";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        try
        {
            txtFeeDolor.Text = "";
            txtAuditFeeRs.Text = "";
            lblMsg.Text = "";
            ddlAudit.Focus();
       }

        catch (Exception)
        {
            
            throw;
        }
    }
}
