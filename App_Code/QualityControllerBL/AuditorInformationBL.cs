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
/// Summary description for AuditorInformationBL
/// </summary>
public class AuditorInformationBL : Connection
{
    public static DataSet ds;
    public AuditorInformationBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private int aUDITORTYPE;
    public int AUDITORTYPE
    {
        get { return aUDITORTYPE; }
        set { aUDITORTYPE = value; }
    }
    private string aUDITORNAME, qUALI, eXPE, iCRDETAILS, lACERTNO, sICCODE;
    public string AUDITORNAME
    {
        get { return aUDITORNAME; }
        set { aUDITORNAME = value; }
    }
    public string QUALI
    {
        get { return qUALI; }
        set { qUALI = value; }
    }
    public string EXPE
    {
        get { return eXPE; }
        set { eXPE = value; }
    }
    public string ICRDETAILS
    {
        get { return iCRDETAILS; }
        set { iCRDETAILS = value; }
    }
    public string LACERTNO
    {
        get { return lACERTNO; }
        set { lACERTNO = value; }
    }
    public string SICCODE
    {
        get { return sICCODE; }
        set { sICCODE = value; }
    }
    private DateTime lADATE;
    public DateTime LADATE
    {
        get { return lADATE; }
        set { lADATE = value; }
    }
    private string aDDRESS1, aDDRESS2, cITY, sTATE, cOUNTRY, pHONE, mOBILE, fAX, eMAIL;
    public string ADDRESS1
    {
        get { return aDDRESS1; }
        set { aDDRESS1 = value; }
    }
    public string ADDRESS2
    {
        get { return aDDRESS2; }
        set { aDDRESS2 = value; }
    }
    public string CITY
    {
        get { return cITY; }
        set { cITY = value; }
    }
    public string STATE
    {
        get { return sTATE; }
        set { sTATE = value; }
    }
    public string COUNTRY
    {
        get { return cOUNTRY; }
        set { cOUNTRY = value; }
    }
    public string PHONE
    {
        get { return pHONE; }
        set { pHONE = value; }
    }
    public string MOBILE
    {
        get { return mOBILE; }
        set { mOBILE = value; }
    }
    public string FAX
    {
        get { return fAX; }
        set { fAX = value; }
    }
    public string EMAIL
    {
        get { return eMAIL; }
        set { eMAIL = value; }
    }
    private int aUDITORID, aDDRESSID;
    public int AUDITORID
    {
        get { return aUDITORID; }
        set { aUDITORID = value; }
    }
    public int ADDRESSID
    {
        get { return aDDRESSID; }
        set { aDDRESSID = value; }
    }
    private char iSACTIVE;
    public char ISACTIVE
    {
        get { return iSACTIVE; }
        set { iSACTIVE = value; }

    }
    public void InsertAuditor()
    {
        SqlParameter[] p = new SqlParameter[17];
        p[0] = new SqlParameter("@AUDITORTYPE", this.aUDITORTYPE);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@AUDITORNAME", this.aUDITORNAME);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@QUALI", this.qUALI);
        p[2].DbType = DbType.String;
        p[3] = new SqlParameter("@EXPE", this.eXPE);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@ICRDETAILS", this.iCRDETAILS);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@LACERTNO", this.lACERTNO);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@LADATE", this.lADATE);
        p[6].DbType = DbType.Date;
        p[7] = new SqlParameter("@SICCODE", this.sICCODE);
        p[7].DbType = DbType.String;
        p[8] = new SqlParameter("@ADDRESS1", this.aDDRESS1);
        p[8].DbType = DbType.String;
        p[9] = new SqlParameter("@ADDRESS2", this.aDDRESS2);
        p[9].DbType = DbType.String;
        p[10] = new SqlParameter("@CITY", this.cITY);
        p[10].DbType = DbType.String;
        p[11] = new SqlParameter("@STATE", this.sTATE);
        p[11].DbType = DbType.String;
        p[12] = new SqlParameter("@COUNTRY", this.cOUNTRY);
        p[12].DbType = DbType.String;
        p[13] = new SqlParameter("@PHONE", this.pHONE);
        p[13].DbType = DbType.String;
        p[14] = new SqlParameter("@MOBILE", this.mOBILE);
        p[14].DbType = DbType.String;
        p[15] = new SqlParameter("@FAX", this.fAX);
        p[15].DbType = DbType.String;
        p[16] = new SqlParameter("@EMAIL", this.eMAIL);
        p[16].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_InsertAuditor", p);
    }
    public DataSet ShowAuditorInfo()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowAuditorInfo");
        return ds;
    }
    public DataSet ShowAuditorDetailByAuditorID()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@auditorid", this.aUDITORID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowAuditorDetailByAuditorID", p);
        return ds;
    }
    public DataSet ShowSICCODE()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@auditorid", this.aUDITORID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowSICCODE", p);
        return ds;
    }
    public DataSet ShowDetailByAuditorTypeId()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@auditortypeid", this.aUDITORTYPE);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowDetailByAuditorTypeId", p);
        return ds;
    }

    public DataSet GetAddressIdByAuditorID()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@auditorid", this.aUDITORID);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpGetAddressIdByAuditorID", p);
        return ds;
    }
    public void ModifyAuditor()
    {
        SqlParameter[] p = new SqlParameter[9];
        p[0] = new SqlParameter("@auditorid", this.aUDITORID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@AUDITORTYPE", this.aUDITORTYPE);
        p[1].DbType = DbType.Int32;
        p[2] = new SqlParameter("@AUDITORNAME", this.aUDITORNAME);
        p[2].DbType = DbType.String;
        p[3] = new SqlParameter("@QUALI", this.qUALI);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@EXPE", this.eXPE);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@ICRDETAILS", this.iCRDETAILS);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@LACERTNO", this.lACERTNO);
        p[6].DbType = DbType.String;
        p[7] = new SqlParameter("@LADATE", this.lADATE);
        p[7].DbType = DbType.Date;
        p[8] = new SqlParameter("@ISACTIVE ", this.iSACTIVE);
        p[8].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyAuditor", p);
    }
    public void ModifyAuditorAddress()
    {
        SqlParameter[] p = new SqlParameter[12];
        p[0] = new SqlParameter("@ADDRESSID", this.aDDRESSID);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@AUDITORID", this.aUDITORID);
        p[1].DbType = DbType.Int32;
        p[2] = new SqlParameter("@ADDRESS1", this.aDDRESS1);
        p[2].DbType = DbType.String;
        p[3] = new SqlParameter("@ADDRESS2", this.aDDRESS2);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@CITY", this.cITY);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@STATE", this.sTATE);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@COUNTRY", this.cOUNTRY);
        p[6].DbType = DbType.String;
        p[7] = new SqlParameter("@PHONE", this.pHONE);
        p[7].DbType = DbType.String;
        p[8] = new SqlParameter("@MOBILE", this.mOBILE);
        p[8].DbType = DbType.String;
        p[9] = new SqlParameter("@FAX", this.fAX);
        p[9].DbType = DbType.String;
        p[10] = new SqlParameter("@EMAIL", this.eMAIL);
        p[10].DbType = DbType.String;
        p[11] = new SqlParameter("@ISACTIVE",SqlDbType.Char);
        p[11].Value = this.iSACTIVE;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "sp_ModifyAuditorAddress", p);
    }
    public DataSet ShowAuditorPersonalInfo()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@auditortypeid", this.aUDITORTYPE);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@auditorname", this.aUDITORNAME);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowAuditorInfo", p);
        return ds;
    }
    public DataSet ShowAuditorAddressInfo()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@auditortypeid", this.aUDITORTYPE);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@auditorname", this.aUDITORNAME);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowAuditorAddressInfo", p);
        return ds;
    }
    public DataSet ShowAvailableAuditor()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@date", this.lADATE);
        p[0].DbType = DbType.Date;
        p[1] = new SqlParameter("@siccode", this.sICCODE);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowAvailableAuditor", p);
        return ds;
    }
}