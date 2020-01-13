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
/// Summary description for CommunicationTypeBL
/// </summary>
public class CommunicationTypeBL:Connection
{
    public static DataSet ds;
	public CommunicationTypeBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _COMMTYPE, _COMMDESC;
    public string COMMTYPE
    {
        get { return _COMMTYPE; }
        set { _COMMTYPE = value; }
    }
    public string COMMDESC
    {
        get { return _COMMDESC; }
        set { _COMMDESC = value; }
    }
    private int _COMMTYPEID;
    public int COMMTYPEID
    {
        get { return _COMMTYPEID; }
        set { _COMMTYPEID = value; }
    }
    public void InsertCommunicationType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@COMMTYPE", this._COMMTYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@COMMDESC", this._COMMDESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "Sp_InsertCommunicationType", p);
    }
    public DataSet GetAllCommTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllCommTypes");
        return ds;
    }
    public DataSet GetSelectedCommType()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@COMMTYPEID", this._COMMTYPEID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedCommType", p);
        return ds;
    }
    public void ModifyCommType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@COMM_TYPE_ID", this._COMMTYPEID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@COMM_TYPE", this._COMMTYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@COMM_DESC", this._COMMDESC);
        p[2].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyCommType", p);
    }
    public DataSet ShowCommunicationInfo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@commtypeid", this._COMMTYPEID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowCommunicationInfo", p);
        return ds;
    }
}
