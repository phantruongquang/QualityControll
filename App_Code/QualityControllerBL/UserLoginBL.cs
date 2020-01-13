using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using QualityController.DAL;
/// <summary>
/// Summary description for UserLoginBL
/// </summary>
public class UserLoginBL:Connection
{
    public static DataSet ds;
	public UserLoginBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
  private string uSERNAME,pASSWORD;
    public string USERNAME
    {
        get { return uSERNAME; }
        set { uSERNAME = value; }
    }
    public string PASSWORD
    {
        get { return pASSWORD; }
        set { pASSWORD = value; }
    }
  private int rOLEID,uSERID;
    public int ROLEID
    {
        get { return rOLEID; }
        set { rOLEID = value; }
    }
    public int USERID
    {
        get { return uSERID; }
        set { uSERID = value; }
    }
    public void InsertUser()
    { 
    SqlParameter[] p=new SqlParameter[3];
        p[0]=new SqlParameter("@USERNAME",this.uSERNAME);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@PASSWORD", this.pASSWORD);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@ROLEID", this.rOLEID);
        p[2].DbType = DbType.Int32;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertUser", p);
    }
    public DataSet GetAllUsers()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllUsers");
        return ds;

    }
    public DataSet ShowUser()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowUser");
        return ds;

    }
    public bool ChekUserAvailable()
    {
        int count;
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@username", this.uSERNAME);
        p[0].DbType = DbType.String;
        count = int.Parse(SqlHelper.ExecuteScalar(con, CommandType.StoredProcedure, "sp_GetUserID", p).ToString());
        if (count > 0)
            return true;
        else
            return false;
    }
    public DataSet GetSelectedUser()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@userid", this.uSERID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedUser",p);
        return ds;
    }
    public void ModifyUser()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@USERNAME", this.uSERNAME);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@PASSWORD", this.pASSWORD);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyUser", p);
    }
    public void DeleteUser()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@USERNAME", this.uSERNAME);
        p[0].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_DeleteUser", p);
    }
}
