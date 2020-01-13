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
/// Summary description for AuditFrequencyTypeBL
/// </summary>
public class AuditFrequencyTypeBL:Connection
{
    public static DataSet ds;
	public AuditFrequencyTypeBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _AUDITFREQ_TYPE, _AUDITFREQ_TYPE_DESC;

    public string AUDITFREQ_TYPE
    {
        get { return _AUDITFREQ_TYPE; }
        set { _AUDITFREQ_TYPE = value; }
    }
    public string AUDITFREQ_TYPE_DESC
    {
        get { return _AUDITFREQ_TYPE_DESC; }
        set { _AUDITFREQ_TYPE_DESC = value; }
    }
    private int _AUDITFREQ_TYPE_ID;
    public int AUDITFREQ_TYPE_ID
    {
        get { return _AUDITFREQ_TYPE_ID; }
        set { _AUDITFREQ_TYPE_ID = value; }
    }
    public void InsertAuditFreqType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@AUDITFREQ_TYPE", this._AUDITFREQ_TYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@AUDITFREQ_TYPE_DESC", this._AUDITFREQ_TYPE_DESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertAuditFreqType", p);
    }
    public DataSet GetAllAuditFreqTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllAuditFreqTypes");
        return ds;
    }
    public DataSet GetSelectedAuditFreq()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@AUDITFREQ_TYPE_ID", this._AUDITFREQ_TYPE_ID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedAuditFreq",p);
        return ds;
    }
    public void ModifyAuditFreqType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@AUDITFREQ_TYPE_ID", this._AUDITFREQ_TYPE_ID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@AUDITFREQ_TYPE", this._AUDITFREQ_TYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@AUDITFREQ_TYPE_DESC", this._AUDITFREQ_TYPE_DESC);
        p[2].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyAuditFreqType", p);
    }
}
