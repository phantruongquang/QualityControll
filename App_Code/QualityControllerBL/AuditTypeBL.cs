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
/// Summary description for AuditTypeBL
/// </summary>
public class AuditTypeBL:Connection
{
    public static DataSet ds;
	public AuditTypeBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _AUDIT_TYPE, _AUDIT_TYPE_DESC;

    public string AUDIT_TYPE_DESC
    {
        get { return _AUDIT_TYPE_DESC; }
        set { _AUDIT_TYPE_DESC = value; }
    }

    public string AUDIT_TYPE
    {
        get { return _AUDIT_TYPE; }
        set { _AUDIT_TYPE = value; }
    }
    private int _AUDIT_TYPE_ID;
    public int AUDIT_TYPE_ID
    {
        get { return _AUDIT_TYPE_ID; }
        set { _AUDIT_TYPE_ID = value; }
    }
    public void InsertAuditType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@AUDIT_TYPE", this._AUDIT_TYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@AUDIT_TYPE_DESC", this._AUDIT_TYPE_DESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertAuditType", p);
    }
    public DataSet GetAllAuditTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllAuditTypes");
        return ds;
    
    }

    public DataSet GetSelectedAuditType()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@AUDIT_TYPE_ID", this._AUDIT_TYPE_ID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedAuditType", p);
        return ds;
    }
    public void ModifyAuditType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@AUDIT_TYPE_ID", this._AUDIT_TYPE_ID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@AUDIT_TYPE", this._AUDIT_TYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@AUDIT_TYPE_DESC", this._AUDIT_TYPE_DESC);
        p[2].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyAuditType", p);
    }
}
