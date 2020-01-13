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
/// Summary description for AccrediationBodyBL
/// </summary>
public class AccrediationBodyBL:Connection
{
    public static DataSet ds;
	public AccrediationBodyBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _ACCRBODY_TYPE, _ACCRBODY_TYPE_DESC;

    public string ACCRBODY_TYPE_DESC
    {
        get { return _ACCRBODY_TYPE_DESC; }
        set { _ACCRBODY_TYPE_DESC = value; }
    }

    public string ACCRBODY_TYPE
    {
        get { return _ACCRBODY_TYPE; }
        set { _ACCRBODY_TYPE = value; }
    }
    int aCCRBODY_TYPE_ID;
    public int ACCRBODY_TYPE_ID
    {
        get { return aCCRBODY_TYPE_ID; }
        set { aCCRBODY_TYPE_ID = value; }
    }
    public void InsertAccrBodyType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@ACCRBODY_TYPE", this._ACCRBODY_TYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@ACCRBODY_TYPE_DESC", this._ACCRBODY_TYPE_DESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertAccrBodyType", p);
    }
    public DataSet GetAllAccrBodyTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllAccrBodyTypes");
        return ds;
    }
    public DataSet GetSelectedAccrBody()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@ACCRBODY_TYPE_ID", this.aCCRBODY_TYPE_ID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedAccrBody",p);
        return ds;
    }
    public void ModifyAccrBodyType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@ACCRBODY_TYPE_ID", this.aCCRBODY_TYPE_ID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@ACCRBODY_TYPE", this._ACCRBODY_TYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@ACCRBODY_TYPE_DESC", this._ACCRBODY_TYPE_DESC);
        p[2].DbType = DbType.String;

        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyAccrBodyType", p);
    }
}
