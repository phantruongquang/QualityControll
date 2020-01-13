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

public partial class Auditors_Modify_frmModifyAuditorDetails : System.Web.UI.Page
{
    AuditorInformationBL auditorinfo = new AuditorInformationBL();
    AuditorTypeBL auditor = new AuditorTypeBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlAuditorType.DataSource = auditor.GetAllAuditorTypes();
            ddlAuditorType.DataTextField = "AUDITOR_TYPE";
            ddlAuditorType.DataValueField = "AUDITOR_TYPE_ID";
            ddlAuditorType.DataBind();

            

            auditorinfo.AUDITORID = int.Parse(Session["AuditorId"].ToString());
            DataSet ds = new DataSet();
            ds = auditorinfo.ShowAuditorDetailByAuditorID();
           
            ListItem li1 = ddlAuditorType.Items.FindByValue(ds.Tables[0].Rows[0][16].ToString());
            if (li1 != null)
            {
                li1.Selected = true;
            }
            txtAuditorName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtQualification.Text = ds.Tables[0].Rows[0][2].ToString();
            txtExp.Text = ds.Tables[0].Rows[0][3].ToString();
            txtIRCANo.Text = ds.Tables[0].Rows[0][4].ToString();
            txtLacertNo.Text = ds.Tables[0].Rows[0][5].ToString();
            GMDatePicker1.Date =Convert.ToDateTime(ds.Tables[0].Rows[0][6].ToString());
            txtAddr1.Text = ds.Tables[0].Rows[0][7].ToString();
            txtAddr2.Text = ds.Tables[0].Rows[0][8].ToString();
            txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
            txtState.Text = ds.Tables[0].Rows[0][10].ToString();
            txtCountry.Text = ds.Tables[0].Rows[0][11].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][12].ToString();
            txtPhone.Text = ds.Tables[0].Rows[0][13].ToString();
            txtFax.Text = ds.Tables[0].Rows[0][14].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][15].ToString();

        }

    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
        try
        {  
            auditorinfo.AUDITORID = int.Parse(Session["AuditorId"].ToString());
            DataSet ds1 = new DataSet();
            ds1 = auditorinfo.GetAddressIdByAuditorID();
           
            auditorinfo.AUDITORTYPE = int.Parse(ddlAuditorType.SelectedValue);
            auditorinfo.AUDITORNAME = txtAuditorName.Text.Trim();
            auditorinfo.QUALI = txtQualification.Text.Trim();
            auditorinfo.EXPE = txtExp.Text.Trim();
            auditorinfo.ICRDETAILS = txtIRCANo.Text.Trim();
            auditorinfo.LACERTNO = txtLacertNo.Text.Trim();
            auditorinfo.LADATE = GMDatePicker1.Date.Date;
            auditorinfo.ISACTIVE =Convert.ToChar('1');
          
            auditorinfo.ADDRESSID =int.Parse(ds1.Tables[0].Rows[0][0].ToString());
            auditorinfo.AUDITORID = int.Parse(Session["AuditorId"].ToString());
            auditorinfo.ADDRESS1 = txtAddr1.Text.Trim();
            auditorinfo.ADDRESS2 = txtAddr2.Text.Trim();
            auditorinfo.CITY = txtCity.Text.Trim();
            auditorinfo.STATE = txtState.Text.Trim();
            auditorinfo.COUNTRY = txtCountry.Text.Trim();
            auditorinfo.PHONE = txtPhone.Text.Trim();
            auditorinfo.MOBILE = txtMobile.Text.Trim();
            auditorinfo.FAX = txtFax.Text.Trim();
            auditorinfo.EMAIL = txtEmail.Text.Trim();
            auditorinfo.ISACTIVE = Convert.ToChar(1);
           // auditorinfo.ModifyAuditor();
            auditorinfo.ModifyAuditorAddress();
            lblMsg.Text = "Updated...!";
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
