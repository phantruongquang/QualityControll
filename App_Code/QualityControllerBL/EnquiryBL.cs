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
/// Summary description for EnquiryBL
/// </summary>
public class EnquiryBL:Connection
{
    public static DataSet ds;
	public EnquiryBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string _ENQUIRY_NO,_REGISTRATIONSCOPE,_HEARABTAQA,_CONSENGDEARLIER,_COMPLETEDBY,_DESIGNATION,_ENQUIRYTYPE,_CONF_MANDAYS,_SURVE_MANDAYS;
    private int _AUDITFREQ_TYPE_ID, _CERT_TYPE_ID, _ACCRBODY_TYPE_ID;
private DateTime _ENQUIRYDT;

public string ENQUIRY_NO
{
    get { return _ENQUIRY_NO; }
    set { _ENQUIRY_NO = value; }
}
public string REGISTRATIONSCOPE
{
    get { return _REGISTRATIONSCOPE; }
    set { _REGISTRATIONSCOPE = value; }
}
public string HEARABTAQA
{
    get { return _HEARABTAQA; }
    set { _HEARABTAQA = value; }
}
public string CONSENGDEARLIER
{
    get { return _CONSENGDEARLIER; }
    set { _CONSENGDEARLIER = value; }
}
public string COMPLETEDBY
{
    get { return _COMPLETEDBY; }
    set { _COMPLETEDBY = value; }
}
public string DESIGNATION
{
    get { return _DESIGNATION; }
    set { _DESIGNATION = value; }
}
public string ENQUIRYTYPE
{
    get { return _ENQUIRYTYPE; }
    set { _ENQUIRYTYPE = value; }
}
public string CONF_MANDAYS
{
    get { return _CONF_MANDAYS; }
    set { _CONF_MANDAYS = value; }
}
public string SURVE_MANDAYS
{
    get { return _SURVE_MANDAYS; }
    set { _SURVE_MANDAYS = value; }
}

public int AUDITFREQ_TYPE_ID
{
    get { return _AUDITFREQ_TYPE_ID; }
    set { _AUDITFREQ_TYPE_ID = value; }
}
public int CERT_TYPE_ID
{
    get { return _CERT_TYPE_ID; }
    set { _CERT_TYPE_ID = value; }
}
public int ACCRBODY_TYPE_ID
{
    get { return _ACCRBODY_TYPE_ID; }
    set { _ACCRBODY_TYPE_ID = value; }
}
public DateTime ENQUIRYDT
{
    get { return _ENQUIRYDT; }
    set { _ENQUIRYDT = value; }
}
public void InsertEnquiry()
{
    SqlParameter[] p = new SqlParameter[13];
    p[0] = new SqlParameter("@ENQUIRY_NO", this._ENQUIRY_NO);
    p[0].DbType = DbType.String;
    p[1] = new SqlParameter("@REGISTRATIONSCOPE", this._REGISTRATIONSCOPE);
    p[1].DbType = DbType.String;
    p[2] = new SqlParameter("@AUDITFREQ_TYPE_ID", this._AUDITFREQ_TYPE_ID);
    p[2].DbType = DbType.Int32;
    p[3] = new SqlParameter("@HEARABTAQA", this._HEARABTAQA);
    p[3].DbType = DbType.String;
    p[4] = new SqlParameter("@CONSENGDEARLIER", this._CONSENGDEARLIER);
    p[4].DbType = DbType.String;
    p[5] = new SqlParameter("@COMPLETEDBY", this._COMPLETEDBY);
    p[5].DbType = DbType.String;
    p[6] = new SqlParameter("@DESIGNATION", this._DESIGNATION);
    p[6].DbType = DbType.String;
    p[7] = new SqlParameter("@ENQUIRYDT", this._ENQUIRYDT);
    p[7].DbType = DbType.Date;
    p[8] = new SqlParameter("@ENQUIRYTYPE", this._ENQUIRYTYPE);
    p[8].DbType = DbType.String;
    p[9] = new SqlParameter("@CERT_TYPE_ID", this._CERT_TYPE_ID);
    p[9].DbType = DbType.Int32;
    p[10] = new SqlParameter("@ACCRBODY_TYPE_ID", this._ACCRBODY_TYPE_ID);
    p[10].DbType = DbType.Int32;
    p[11] = new SqlParameter("@CONF_MANDAYS", this._CONF_MANDAYS);
    p[11].DbType = DbType.String;
    p[12] = new SqlParameter("@SURVE_MANDAYS", this._SURVE_MANDAYS);
    p[12].DbType = DbType.String;
    SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "SpInsertEnquiry", p);
}
public DataSet GetAllEnquiryNo()
{
    ds = new DataSet();
    ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_GetAllEnquiryNo");
    return ds;

}
}
