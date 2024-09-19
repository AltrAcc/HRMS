using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public int? Userid { get; set; }

    public int? ReviewCount { get; set; }

    public string? Employeetype { get; set; }

    public string? Employeecode { get; set; }

    public int? Employeecodeid { get; set; }

    public string? Employeefirstname { get; set; }

    public string? Employeelastname { get; set; }

    public DateTime? Employeedob { get; set; }

    public string? Employeegender { get; set; }

    public string? Employeemaritalstatus { get; set; }

    public string? Employeebloodgroup { get; set; }

    public int? Roleid { get; set; }

    public string? Employeecontactno1 { get; set; }

    public long? Employeecontactno2 { get; set; }

    public string? Employeeemailid { get; set; }

    public string TShirtsize { get; set; } = null!;

    public string? Referencefromcurrentemp { get; set; }

    public string? Referenceempname { get; set; }

    public long? Referenceempno { get; set; }

    public string? Otherreferencename { get; set; }

    public long? Otherreferenceno { get; set; }

    public string? Employeeeaddress { get; set; }

    public string Employeecurrentaddress { get; set; } = null!;

    public string? Employeeecity { get; set; }

    public string? Employeeepincode { get; set; }

    public string? Employeestate { get; set; }

    public string? Experience { get; set; }

    public int? ExperianceYear { get; set; }

    public string? PreviousCompanyname { get; set; }

    public string? JobProfile { get; set; }

    public string? Icedetailsname { get; set; }

    public string? Icedetailsrelationship { get; set; }

    public string? Icedetailscontactno1 { get; set; }

    public string? Icedetailscontactno2 { get; set; }

    public DateTime? Dateofjoining { get; set; }

    public DateTime? Dateofregine { get; set; }

    public string? Location { get; set; }

    public string? Department { get; set; }

    public string? Subdepartment { get; set; }

    public string? Jobdesignation { get; set; }

    public string? Shift { get; set; }

    public string? Otapplicable { get; set; }

    public string? Accommodation { get; set; }

    public string? Leftservice { get; set; }

    public DateTime? Leftservicedate { get; set; }

    public string? Leftservicereason { get; set; }

    public string? Pfapplicable { get; set; }

    public string? Pfaccountno { get; set; }

    public DateTime? Pfdoj { get; set; }

    public string? Esiapplicable { get; set; }

    public string? Esinumber { get; set; }

    public string? Esidispensary { get; set; }

    public string? Bankdetailsaccounttype { get; set; }

    public string? Bankholdername { get; set; }

    public long? Bankaccountnumber { get; set; }

    public string? Bankname { get; set; }

    public string? Bankifscode { get; set; }

    public string? Bankbranch { get; set; }

    public string? Applicantresume { get; set; }

    public string? Photo { get; set; }

    public string? Pancard { get; set; }

    public string? Aadharfront { get; set; }

    public string? Aadharback { get; set; }

    public string? Drivinglicense { get; set; }

    public string? Expirydate { get; set; }

    public string Remindonexpiry { get; set; } = null!;

    public string? Pancardno { get; set; }

    public string? Aadharcardno { get; set; }

    public string? Passportno { get; set; }

    public string? Linkedin { get; set; }

    public string? Facebook { get; set; }

    public string? Twitter { get; set; }

    public string? Instagram { get; set; }

    public string SmsStatus { get; set; } = null!;

    public string TrackingSmsStatus { get; set; } = null!;

    public string PunchtimeSmsStatus { get; set; } = null!;

    public string EdittrackingStatus { get; set; } = null!;

    public string? Employeecurrentcity { get; set; }

    public string? Employeeecurrentpincode { get; set; }

    public string? Employeewhatsappnumber { get; set; }

    public string WorkfromStatus { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
