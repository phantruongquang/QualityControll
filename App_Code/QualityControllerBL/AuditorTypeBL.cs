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
/// Summary description for AuditorTypeBL
/// </summary>
public class AuditorTypeBL:Connection
{
    public static DataSet ds;
	public AuditorTypeBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _AUDITOR_TYPE, _AUDITOR_TYPE_DESC;
    public string AUDITOR_TYPE
    {
        get { return _AUDITOR_TYPE; }
        set { _AUDITOR_TYPE = value; }
    }
    public string AUDITOR_TYPE_DESC
    {
        get { return _AUDITOR_TYPE_DESC; }
        set { _AUDITOR_TYPE_DESC = value; }
    }
    private int _AUDITOR_TYPE_ID;
    public int AUDITOR_TYPE_ID
    {
        get { return _AUDITOR_TYPE_ID; }
        set { _AUDITOR_TYPE_ID = value; }
    }
    public void InsertAuditorType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@AUDITOR_TYPE", this._AUDITOR_TYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@AUDITOR_TYPE_DESC", this._AUDITOR_TYPE_DESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertAuditorType", p);
    }
    public DataSet GetAllAuditorTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllAuditorTypes");
        return ds;

    }
    public DataSet GetSelectedAuditorType()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@AUDITOR_TYPE_ID", this._AUDITOR_TYPE_ID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedAuditorType",p);
        return ds;
  }
    public void ModifyAuditorType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@AUDITOR_TYPE_ID", this._AUDITOR_TYPE_ID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@AUDITOR_TYPE", this._AUDITOR_TYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@AUDITOR_TYPE_DESC", this._AUDITOR_TYPE_DESC);
        p[2].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyAuditorType", p);
    }
}
