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
using System.Data.SqlClient;

public partial class frmLogin : System.Web.UI.Page
{
    UserLoginBL login = new UserLoginBL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnStr"]);
            SqlCommand cmd = new SqlCommand("select roleid from tb_user where username='" + txtUname.Text + "' and password='" + txtPassword.Text + "'", con);
            con.Open();
            object o = cmd.ExecuteScalar();

            if (o != null)
            {
                switch (Convert.ToInt32(o))
                {
                    case 1:
                        {
                            
                            Response.Redirect(@"/QualityTool/Admin/frmAdminHome.aspx");
                            //Response.Redirect("frmAdminHome.aspx");
                            break;
                        }
                    case 2:
                        {
                            Response.Redirect(@"/QualityTool/Auditors/frmAuditorHome.aspx");
                            break;
                        }                    
                }
            }
            else
            {
                lblMsg.Text = "Invalid User Name/Password";
            }


            

        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message.ToString();
        }

    }
}
