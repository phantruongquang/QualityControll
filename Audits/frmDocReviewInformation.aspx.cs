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

public partial class Audits_frmDocReviewInformation : System.Web.UI.Page
{
    RegistrationInfoBL regis = new RegistrationInfoBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           regis.Fileno=Session["FileNo"].ToString();
           regis.Regno =Convert.ToInt32(Session["RegNo"].ToString());
            DataSet ds=new DataSet();
            ds=regis.GetDocumentReview();
           lblFileNo.Text = regis.Fileno;
           lblFileDate.Text = ds.Tables[0].Rows[0][1].ToString();
           lblFileStorage.Text = ds.Tables[0].Rows[0][2].ToString(); ;
           lblEnqNo.Text = ds.Tables[0].Rows[0][3].ToString();
           lblEnqType.Text = ds.Tables[0].Rows[0][4].ToString();
           lblEnqDate.Text = ds.Tables[0].Rows[0][5].ToString();
           lblQuotNo.Text = ds.Tables[0].Rows[0][6].ToString();
           lblQuotDate.Text = ds.Tables[0].Rows[0][7].ToString();
           lblCompName.Text = ds.Tables[0].Rows[0][8].ToString();
           lblSICCode.Text=ds.Tables[0].Rows[0][9].ToString();
           lblAccrBody.Text = ds.Tables[0].Rows[0][10].ToString();
           lblAuditFreq.Text = ds.Tables[0].Rows[0][11].ToString();
           lblScope.Text = ds.Tables[0].Rows[0][12].ToString();
           lblCertType.Text = ds.Tables[0].Rows[0][13].ToString();
           lblCertNo.Text = ds.Tables[0].Rows[0][14].ToString();
           lblCertDate.Text=ds.Tables[0].Rows[0][15].ToString();
           lblCertValidDate.Text= ds.Tables[0].Rows[0][16].ToString();

               
           if (ds.Tables[0].Rows[0][24].ToString() != null && ds.Tables[0].Rows[0][24].ToString() != "")
           {
              
               GMDatePicker3.Date = Convert.ToDateTime(ds.Tables[0].Rows[0][24].ToString());

           }
       
           if (ds.Tables[0].Rows[0][20].ToString() != null && ds.Tables[0].Rows[0][20].ToString() != "")
           {
              
               GMDatePicker6.Date = Convert.ToDateTime(ds.Tables[0].Rows[0][20].ToString());

           }
         
           txtReviewBy.Text = ds.Tables[0].Rows[0][23].ToString();
           txtComment.Text = ds.Tables[0].Rows[0][26].ToString();
           if (ds.Tables[0].Rows[0][25].ToString() != null && ds.Tables[0].Rows[0][25].ToString() != "")
           {

               GMDatePicker8.Date = Convert.ToDateTime(ds.Tables[0].Rows[0][25].ToString());

           }
          
           if (ds.Tables[0].Rows[0][27].ToString() != null && ds.Tables[0].Rows[0][27].ToString() != "")
           {

               GMDatePicker7.Date = Convert.ToDateTime(ds.Tables[0].Rows[0][27].ToString());

           }
        
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

    }
}
