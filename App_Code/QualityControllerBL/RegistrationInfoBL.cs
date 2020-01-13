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
/// Summary description for RegistrationInfoBL
/// </summary>
public class RegistrationInfoBL:Connection
{
    public static DataSet ds;
	public RegistrationInfoBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string enqno, quotationno, certificateno, fileno;
    private int  regno;
    public int Regno
    {
        get { return regno; }
        set { regno = value; }
    }
    public string Fileno
    {
        get { return fileno; }
        set { fileno = value; }
    }
    public string Enqno
    {
        get { return enqno; }
        set { enqno = value; }
    }
    public string Quotationno
    {
        get { return quotationno; }
        set { quotationno = value; }
    }
    public string Certificateno
    {
        get { return certificateno; }
        set { certificateno = value; }
    }
    private DateTime certificatedate, certificatevalidity;
    public DateTime Certificatedate
    {
        get { return certificatedate; }
        set { certificatedate = value; }
    }
    public DateTime Certificatevalidity
    {
        get { return certificatevalidity; }
        set { certificatevalidity = value; }
    }
    private char iswithdrawn, isprobation;
    public char Iswithdrawn
    {
        get { return iswithdrawn; }
        set { iswithdrawn = value; }
    }
    public char Isprobation
    {
        get { return isprobation; }
        set { isprobation = value; }
    }
    public DataSet ShowRegistration()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@enqno", this.enqno);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@quotationno", this.quotationno);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowRegistration",p);
        return ds;
    }
    public DataSet ShowFileInfo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@fileno", this.fileno);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowFileInfo", p);
        return ds;
    }
    public void InsertCertificateInfo()
    {
        SqlParameter[] p = new SqlParameter[6];
        p[0] = new SqlParameter("@certificateno", this.certificateno);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@regno", this.regno);
        p[1].DbType = DbType.Int32;
        p[2] = new SqlParameter("@certificatedate", this.certificatedate);
        p[2].DbType = DbType.Date;
        p[3] = new SqlParameter("@certificatevalidity", this.certificatevalidity);
        p[3].DbType = DbType.Date;
        p[4] = new SqlParameter("@iswithdrawn", this.iswithdrawn);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@isprobation", this.isprobation);
        p[5].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertCertificateInfo", p);
    }
    public DataSet Showregisno()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@fileno", this.fileno);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SP_Showregisno", p);
        return ds;
    }
    public DataSet GetSelectedCertInfo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@regno", this.regno);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "sp_GetSelectedCertInfo", p);
        return ds;
    }
    public DataSet GetDocumentReview()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@regno", this.regno);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@fileno", this.fileno);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_GetDocumentReview", p);
        return ds;
    }
    public DataSet ShowCertificateInfo()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@certno", this.regno);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@fileno", this.fileno);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowCertificateInfo", p);
        return ds;
    }
}
