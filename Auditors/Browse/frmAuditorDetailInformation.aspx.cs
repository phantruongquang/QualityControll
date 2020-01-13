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

public partial class Auditors_Browse_frmAuditorDetailInformation : System.Web.UI.Page
{
    AuditorInformationBL auditorinfo = new AuditorInformationBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            auditorinfo.AUDITORID =int.Parse(Session["AuditorId"].ToString());
            DataSet ds = new DataSet();
            ds = auditorinfo.ShowAuditorDetailByAuditorID();

            txtAuditorType.Text = ds.Tables[0].Rows[0][0].ToString();
            txtAuditorName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtQualification.Text = ds.Tables[0].Rows[0][2].ToString();
            txtExp.Text = ds.Tables[0].Rows[0][3].ToString();
            txtIRCANo.Text = ds.Tables[0].Rows[0][4].ToString();
            txtLacertNo.Text = ds.Tables[0].Rows[0][5].ToString();
            txtDate.Text = ds.Tables[0].Rows[0][6].ToString();
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
}
