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
/// Summary description for CertificateTypeBL
/// </summary>
public class CertificateTypeBL:Connection
{
    public static DataSet ds;
	public CertificateTypeBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _CERT_TYPE, _CERT_TYPE_DESC;
    public string CERT_TYPE_DESC
    {
        get { return _CERT_TYPE_DESC; }
        set { _CERT_TYPE_DESC = value; }
    }

    public string CERT_TYPE
    {
        get { return _CERT_TYPE; }
        set { _CERT_TYPE = value; }
    }
    private int _CERT_TYPE_ID;
    public int CERT_TYPE_ID
    {
        get { return _CERT_TYPE_ID; }
        set { _CERT_TYPE_ID = value; }
    }
    public void InsertCertificateType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@CERT_TYPE", this._CERT_TYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@CERT_TYPE_DESC", this._CERT_TYPE_DESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertCertType", p);
    }
    public DataSet GetAllCertTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllCertTypes");
        return ds;
    }
    public DataSet GetSelectedCertType()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@CERT_TYPE_ID", this._CERT_TYPE_ID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedCertType",p);
        return ds;
    }
    public void ModifyCertType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@CERT_TYPE_ID", this._CERT_TYPE_ID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@CERT_TYPE", this._CERT_TYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@CERT_TYPE_DESC", this._CERT_TYPE_DESC);
        p[2].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyCertType", p);
    }
}
