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
/// Summary description for QuotationBL
/// </summary>
public class QuotationBL:Connection
{
    public static DataSet ds;
	public QuotationBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private char _IS_APPROVED;
  private string _QUOTATIONNO,_ENQUIRY_NO;
    public string QUOTATIONNO
    {
        get { return _QUOTATIONNO; }
        set { _QUOTATIONNO = value; }
    }
    public string ENQUIRY_NO
    {
        get { return _ENQUIRY_NO; }
        set { _ENQUIRY_NO = value; }
    }
    public char IS_APPROVED
    {
        get { return _IS_APPROVED; }
        set { _IS_APPROVED = value; }
    }
private DateTime _QUOTATIONDT,_APPROVEDDATE;
    public DateTime QUOTATIONDT
    {
        get { return _QUOTATIONDT; }
        set { _QUOTATIONDT = value; }
    }
    public DateTime APPROVEDDATE
    {
        get { return _APPROVEDDATE; }
        set { _APPROVEDDATE = value; }
    }
    private int _AUDIT_TYPE_ID, _AUDITFEESRS, _AUDITFEESDLR;
    public int AUDIT_TYPE_ID
    {
        get { return _AUDIT_TYPE_ID; }
        set { _AUDIT_TYPE_ID = value; }
    }
    public int AUDITFEESRS
    {
        get { return _AUDITFEESRS; }
        set { _AUDITFEESRS = value; }
    }
    public int AUDITFEESDLR
    {
        get { return _AUDITFEESDLR; }
        set { _AUDITFEESDLR = value; }
    }
    public void QuotationDetailsInsert()
    {
        SqlParameter[] p = new SqlParameter[5];
        p[0] = new SqlParameter("@QUOTATIONNO", this._QUOTATIONNO);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@ENQUIRY_NO", this._ENQUIRY_NO);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@QUOTATIONDT", this._QUOTATIONDT);
        p[2].DbType = DbType.Date;
        p[3] = new SqlParameter("@IS_APPROVED", this._IS_APPROVED);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@APPROVEDDATE", this._APPROVEDDATE);
        p[4].DbType = DbType.Date;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_QuotationDetailsInsert", p);
    }
    public void QuotationFeesDetailsInsert()
    {
        SqlParameter[] p = new SqlParameter[4];
        p[0] = new SqlParameter("@QUOTATIONNO", this._QUOTATIONNO);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@AUDIT_TYPE_ID", this._AUDIT_TYPE_ID);
        p[1].DbType = DbType.Int32;
        p[2] = new SqlParameter("@AUDITFEESRS", this._AUDITFEESRS);
        p[2].DbType = DbType.Int32;
        p[3] = new SqlParameter("@AUDITFEESDLR", this._AUDITFEESDLR);
        p[3].DbType = DbType.Int32;
         SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_QuotationFeesDetailsInsert", p);
    }
    public DataSet ShowQuotationInfo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@QUOTATIONNO", this._QUOTATIONNO);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowQuotationInfo",p);
        return ds;

    }
    public DataSet ShowQuotationFeesInfo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@QUOTATIONNO", this._QUOTATIONNO);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowQuotationFeesInfo", p);
        return ds;

    }
    public void ModifyQuotationDetail()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@quotationno", this._QUOTATIONNO);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@quotdate", this._QUOTATIONDT);
        p[1].DbType = DbType.Date;
        p[2] = new SqlParameter("@approvedate", this._APPROVEDDATE);
        p[2].DbType = DbType.Date;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "Sp_ModifyQuotationDetail", p);
    }
    public void ModifyQuotationFees()
    {
        SqlParameter[] p = new SqlParameter[4];
        p[0] = new SqlParameter("@quotationno", this._QUOTATIONNO);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@auditid", this._AUDIT_TYPE_ID);
        p[1].DbType = DbType.Int32;
        p[2] = new SqlParameter("@feers", this._AUDITFEESRS);
        p[2].DbType = DbType.Int32;
        p[3] = new SqlParameter("@feedolor", this._AUDITFEESDLR);
        p[3].DbType = DbType.Int32;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "Sp_ModifyQuotationFees", p);
    }
    public DataSet ShowAllQuotation()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowAllQuotation");
        return ds;

    }

    public void UpdateQuotationApproval(string QuotationNo)
    {
        string str = "update TB_QUOTATION set IS_APPROVED='y' where QUOTATIONNO='" + QuotationNo + "' and  IS_APPROVED='n'";
        SqlHelper.ExecuteNonQuery(con, CommandType.Text, str);
    }
}
