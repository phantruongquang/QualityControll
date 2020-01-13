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
/// Summary description for EnquiryCompanyBL
/// </summary>
public class EnquiryCompanyBL:Connection
{
    public static DataSet ds;
	public EnquiryCompanyBL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string existingEnquiryNo, enquiryNo, registrationScope, hearAbtAqa, consEngdEarlier, completedBy, designation, enquiryType, companyName;
    public string ExistingEnquiryNo
    {
        get { return existingEnquiryNo; }
        set { existingEnquiryNo = value; }

    }
    public string EnquiryNo
    {
        get { return enquiryNo; }
        set { enquiryNo = value; }

    }
    public string RegistrationScope
    {
        get { return registrationScope; }
        set { registrationScope = value; }

    }
    public string HearAbtAqa
    {
        get { return hearAbtAqa; }
        set { hearAbtAqa = value; }

    }
    public string ConsEngdEarlier
    {
        get { return consEngdEarlier; }
        set { consEngdEarlier = value; }

    }
    public string CompletedBy
    {
        get { return completedBy; }
        set { completedBy = value; }

    }
    public string Designation
    {
        get { return designation; }
        set { designation = value; }

    }
    public string EnquiryType
    {
        get { return enquiryType; }
        set { enquiryType = value; }

    }
    public string CompanyName
    {
        get { return companyName; }
        set { companyName = value; }

    }
  
    string mailingAddr1, mailingAddr2, contactPerson, title, compSicCode, iAFCode, industryType, auditLocation, address1, address2, city, state, country, email, telephone, fax, mobile;
    public string MailingAddr1
    {
        get { return mailingAddr1; }
        set { mailingAddr1 = value; }

    }
    public string MailingAddr2
    {
        get { return mailingAddr2; }
        set { mailingAddr2 = value; }
    }
    public string ContactPerson
    {
        get { return contactPerson; }
        set { contactPerson = value; }

    }
    public string Title
    {
        get { return title; }
        set { title = value; }

    }
    public string CompSicCode
    {
        get { return compSicCode; }
        set { compSicCode = value; }

    }
    public string IAFCode
    {
        get { return iAFCode; }
        set { iAFCode = value; }

    }
    public string IndustryType
    {
        get { return industryType; }
        set { industryType = value; }

    }
    public string AuditLocation
    {
        get { return auditLocation; }
        set { auditLocation = value; }

    }
    public string Address1
    {
        get { return address1; }
        set { address1 = value; }

    }
    public string Address2
    {
        get { return address2; }
        set { address2 = value; }

    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string State
    {
        get { return state; }
        set { state = value; }
    }

   
     public string Country
    {
        get { return country; }
        set { country = value; }

    } public string Email
    {
        get { return email; }
        set { email = value; }

    }
    public string Telephone
    {
        get { return telephone; }
        set { telephone = value; }

    }
     public string Fax
    {
        get { return fax; }
        set { fax = value; }

    } public string Mobile
    {
        get { return mobile; }
        set { mobile = value; }

    }
    string shifttime1, shifttime2, confmandays, survemandays;
    public string Shifttime1
    {
        get { return shifttime1; }
        set { shifttime1 = value; }

    }
    public string Shifttime2
    {
        get { return shifttime2; }
        set { shifttime2 = value; }

    }
    public string Confmandays
    {
        get { return confmandays; }
        set { confmandays = value; }

    }
    public string Survemandays
    {
        get { return survemandays; }
        set { survemandays = value; }

    }
   
    char is_active;
    public char Is_active
    {
        get { return is_active; }
        set { is_active = value; }

    }
    int auditFreqTypeId, certTypeId, accrBodyTypeId, shiftid1, totalemp1, shiftid2, totalemp2;
    public int AuditFreqTypeId
    {
        get { return auditFreqTypeId; }
        set { auditFreqTypeId = value; }

    }
    public int CertTypeId
    {
        get { return certTypeId; }
        set { certTypeId = value; }

    }
    public int AccrBodyTypeId
    {
        get { return accrBodyTypeId; }
        set { accrBodyTypeId = value; }

    }
    public int Shiftid1
    {
        get { return shiftid1; }
        set { shiftid1 = value; }

    }
    public int Totalemp1
    {
        get { return totalemp1; }
        set { totalemp1 = value; }

    }
    public int Shiftid2
    {
        get { return shiftid2; }
        set { shiftid2 = value; }

    }
    public int Totalemp2
    {
        get { return totalemp2; }
        set { totalemp2 = value; }

    }
    DateTime enquiryDt;
    public DateTime EnquiryDt
    {
        get { return enquiryDt; }
        set { enquiryDt = value; }

    }
    private int compid;
    public int Compid
    {
        get { return compid; }
        set { compid = value; }

    }
    public void EnquiryInsertion()
    { 
    SqlParameter[] p=new SqlParameter[39];

    //Enquiry Detail

        p[0]=new SqlParameter("@ExistingEnquiryNo",this.existingEnquiryNo);
        p[0].DbType=DbType.String;
        p[1] = new SqlParameter("@EnquiryNo", this.enquiryNo);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@RegistrationScope", this.registrationScope);
        p[2].DbType = DbType.String;
        p[3] = new SqlParameter("@AuditFreqTypeId", this.auditFreqTypeId);
        p[3].DbType = DbType.Int32;
        p[4] = new SqlParameter("@HearAbtAqa", this.hearAbtAqa);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@ConsEngdEarlier", this.consEngdEarlier);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@CompletedBy", this.completedBy);
        p[6].DbType = DbType.String;
        p[7] = new SqlParameter("@Designation", this.designation);
        p[7].DbType = DbType.String;
        p[8] = new SqlParameter("@EnquiryDt", this.enquiryDt);
        p[8].DbType = DbType.String;
        p[9] = new SqlParameter("@EnquiryType", this.enquiryType);
        p[9].DbType = DbType.String;
        p[10] = new SqlParameter("@CertTypeId", this.certTypeId);
        p[10].DbType = DbType.Int32;
        p[11] = new SqlParameter("@AccrBodyTypeId", this.accrBodyTypeId);
        p[11].DbType = DbType.Int32;
       
        
        //Company Detail
        p[12] = new SqlParameter("@CompanyName", this.companyName);
        p[12].DbType = DbType.String;
        p[13] = new SqlParameter("@MailingAddr1", this.mailingAddr1);
        p[13].DbType = DbType.String;
        p[14] = new SqlParameter("@MailingAddr2", this.mailingAddr2);
        p[14].DbType = DbType.String;
        p[15] = new SqlParameter("@ContactPerson", this.contactPerson);
        p[15].DbType = DbType.String;
        p[16] = new SqlParameter("@Title", this.title);
        p[16].DbType = DbType.String;
        p[17] = new SqlParameter("@CompSicCode", this.compSicCode);
        p[17].DbType = DbType.String;
        p[18] = new SqlParameter("@IAFCode", this.iAFCode);
        p[18].DbType = DbType.String;
        p[19] = new SqlParameter("@IndustryType", this.industryType);
        p[19].DbType = DbType.String;
        p[20] = new SqlParameter("@AuditLocation", this.auditLocation);
        p[20].DbType = DbType.String;
        p[21] = new SqlParameter("@Address1", this.address1);
        p[21].DbType = DbType.String;
        p[22] = new SqlParameter("@Address2", this.address2);
        p[22].DbType = DbType.String;
        p[23] = new SqlParameter("@City", this.city);
        p[23].DbType = DbType.String;
        p[24] = new SqlParameter("@State", this.state);
        p[24].DbType = DbType.String;
        p[25] = new SqlParameter("@Country", this.country);
        p[25].DbType = DbType.String;
        p[26] = new SqlParameter("@Email", this.email);
        p[26].DbType = DbType.String;
        p[27] = new SqlParameter("@Telephone", this.telephone);
        p[27].DbType = DbType.String;
        p[28] = new SqlParameter("@Fax", this.fax);
        p[28].DbType = DbType.String;
        p[29] = new SqlParameter("@Mobile", this.mobile);
        p[29].DbType = DbType.String;
        p[30] = new SqlParameter("@is_active", this.is_active);
        p[30].DbType = DbType.String;
        p[31] = new SqlParameter("@shiftid1", this.shiftid1);
        p[31].DbType = DbType.Int32;
        p[32] = new SqlParameter("@shifttime1", this.shifttime1);
        p[32].DbType = DbType.String;
        p[33] = new SqlParameter("@totalemp1", this.@totalemp1);
        p[33].DbType = DbType.Int32;
        p[34] = new SqlParameter("@shiftid2", this.shiftid2);
        p[34].DbType = DbType.Int32;
        p[35] = new SqlParameter("@shifttime2", this.shifttime2);
        p[35].DbType = DbType.String;
        p[36] = new SqlParameter("@totalemp2", this.@totalemp2);
        p[36].DbType = DbType.Int32;
        p[37] = new SqlParameter("@confmandays", this.confmandays);
        p[37].DbType = DbType.String;
        p[38] = new SqlParameter("@survemandays", this.survemandays);
        p[38].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con,CommandType.StoredProcedure,"sp_EnquiryInsert",p);

    }
    public DataSet GetAllEnquiryNo()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_GetAllEnquiryNo");
        return ds;

    }
    public DataSet ShowEnquiryInfo()
    {
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowEnquiryInfo");
        return ds;
    }
    public DataSet ShowAllDetailOfEnquiry()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@enqno", this.enquiryNo);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpAllDetailOfEnqCompany",p);
        return ds;
    }
    public DataSet ShowCompanyDetail()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@enqno", this.enquiryNo);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowCompanyDetail", p);
        return ds;
    }
    public DataSet GetCompanyId()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@enqno", this.enquiryNo);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@compname", this.companyName);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_GetCompanyId", p);
        return ds;
    }
    public DataSet ShowCompAddressDetail()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@compid", this.compid);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowCompAddressDetail", p);
        return ds;
    }
    public DataSet ShowShiftDetail()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@compid", this.compid);
        p[0].DbType = DbType.Int32;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowShiftDetail", p);
        return ds;
    }
    public DataSet ShowEnquiryInfoByEnqNo()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@enqno", this.enquiryNo);
        p[0].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowEnquiryInfoByEnqNo", p);
        return ds;
    }
   
    //Enquiry Updation
    public void UpdateEnquiry()
    {
        SqlParameter[] p = new SqlParameter[13];
        p[0] = new SqlParameter("@EnquiryNo", this.enquiryNo);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@RegistrationScope", this.registrationScope);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@AuditFreqTypeId", this.auditFreqTypeId);
        p[2].DbType = DbType.Int32;
        p[3] = new SqlParameter("@HearAbtAqa", this.hearAbtAqa);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@ConsEngdEarlier", this.consEngdEarlier);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@CompletedBy", this.completedBy);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@Designation", this.designation);
        p[6].DbType = DbType.String;
        p[7] = new SqlParameter("@EnquiryDt", this.enquiryDt);
        p[7].DbType = DbType.String;
        p[8] = new SqlParameter("@EnquiryType", this.enquiryType);
        p[8].DbType = DbType.String;
        p[9] = new SqlParameter("@CertTypeId", this.certTypeId);
        p[9].DbType = DbType.Int32;
        p[10] = new SqlParameter("@AccrBodyTypeId", this.accrBodyTypeId);
        p[10].DbType = DbType.Int32;
        p[11] = new SqlParameter("@confmandays", this.confmandays);
        p[11].DbType = DbType.String;
        p[12] = new SqlParameter("@survemandays", this.survemandays);
        p[12].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "SpUpdateEnquiry", p);

    }

    //Company Updation
    public void UpdateCompanyInfo()
    {
        SqlParameter[] p = new SqlParameter[10];
        p[0] = new SqlParameter("@EnquiryNo", this.enquiryNo);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@CompanyName", this.companyName);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@MailingAddr1", this.mailingAddr1);
        p[2].DbType = DbType.String;
        p[3] = new SqlParameter("@MailingAddr2", this.mailingAddr2);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@ContactPerson", this.contactPerson);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@Title", this.title);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@CompSicCode", this.compSicCode);
        p[6].DbType = DbType.String;
        p[7] = new SqlParameter("@IAFCode", this.iAFCode);
        p[7].DbType = DbType.String;
        p[8] = new SqlParameter("@IndustryType", this.industryType);
        p[8].DbType = DbType.String;
        p[9] = new SqlParameter("@AuditLocation", this.auditLocation);
        p[9].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "SpUpdateCompanyInfo", p);

    }
    public void UpdateShiftDetail()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@compid", this.compid);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@shifttime", this.shifttime1);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@totalemp", this.@totalemp1);
        p[2].DbType = DbType.Int32;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "SpUpdateShiftDetail", p);

    }
    public void UpdateCompanyAddressDetail()
    {
        SqlParameter[] p = new SqlParameter[10];
        p[0] = new SqlParameter("@compid", this.compid);
        p[0].DbType = DbType.Int32;
        p[1] = new SqlParameter("@Address1", this.address1);
        p[1].DbType = DbType.String;
        p[2] = new SqlParameter("@Address2", this.address2);
        p[2].DbType = DbType.String;
        p[3] = new SqlParameter("@City", this.city);
        p[3].DbType = DbType.String;
        p[4] = new SqlParameter("@State", this.state);
        p[4].DbType = DbType.String;
        p[5] = new SqlParameter("@Country", this.country);
        p[5].DbType = DbType.String;
        p[6] = new SqlParameter("@Email", this.email);
        p[6].DbType = DbType.String;
        p[7] = new SqlParameter("@Telephone", this.telephone);
        p[7].DbType = DbType.String;
        p[8] = new SqlParameter("@Fax", this.fax);
        p[8].DbType = DbType.String;
        p[9] = new SqlParameter("@Mobile", this.mobile);
        p[9].DbType = DbType.String;
        SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "SpUpdateCompanyAddressDetail", p);

    }
    private DateTime date1, date2;
    public DateTime Date1
    {
        get { return date1; }
        set { date1 = value; }
    }
    public DateTime Date2
    {
        get { return date2; }
        set { date2 = value; }
    }
    public DataSet ShowEnquiryByDates()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@date1", this.date1);
        p[0].DbType = DbType.Date;
        p[1] = new SqlParameter("@date2", this.date2);
        p[1].DbType = DbType.Date;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Sp_ShowEnquiryByDates", p);
        return ds;
    }
    public DataSet ShowCompanyEnquiryDetail()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@siccode", this.compSicCode);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@companyname", this.companyName);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowCompanyEnquiryDetail", p);
        return ds;
    }
    public DataSet ShowCompanyQuotationInfo()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@siccode", this.compSicCode);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@companyname", this.companyName);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowCompanyQuotationInfo", p);
        return ds;
    }
    public DataSet ShowCompAddDetail()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@siccode", this.compSicCode);
        p[0].DbType = DbType.String;
        p[1] = new SqlParameter("@companyname", this.companyName);
        p[1].DbType = DbType.String;
        ds = new DataSet();
        ds = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SpShowCompAddDetail", p);
        return ds;
    }
}
