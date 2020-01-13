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
/// Summary description for FeedBacktypeBL
/// </summary>
public class FeedBacktypeBL:Connection
{
    public static DataSet ds;
	public FeedBacktypeBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _FEEDBACKTYPE, _FEEDBACKDESC;
    public string FEEDBACKTYPE
    {
        get { return _FEEDBACKTYPE; }
        set { _FEEDBACKTYPE = value; }
    }
    public string FEEDBACKDESC
    {
        get { return _FEEDBACKDESC; }
        set { _FEEDBACKDESC = value; }
    }
    private int _FEEDBACKTYPEID;
    public int FEEDBACKTYPEID
    {
        get { return _FEEDBACKTYPEID; }
        set { _FEEDBACKTYPEID = value; }
    }
    public void InsertFeedbackType()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@FEEDBACKTYPE", this._FEEDBACKTYPE);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@FEEDBACKDESC", this._FEEDBACKDESC);
        p[1].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertFeedbackType", p);
    }
    public DataSet GetAllFeedBackTypes()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetAllFeedBackTypes");
        return ds;
    }
    public DataSet GetSelectedFeedBackType()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@FEEDBACKTYPEID", this._FEEDBACKTYPEID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedFeedBackType", p);
        return ds;
    }
    public void ModifyFeedBackType()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@FEEDBACKTYPEID", this._FEEDBACKTYPEID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@FEEDBACKTYPE", this._FEEDBACKTYPE);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@FEEDBACKDESC", this._FEEDBACKDESC);
        p[2].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyFeedBackType", p);
    }
    public DataSet ShowFeedBackInfo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@feedbackid", this._FEEDBACKTYPEID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowFeedBackInfo", p);
        return ds;
    }
}
