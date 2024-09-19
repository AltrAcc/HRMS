using System;
using System.Collections.Generic;

namespace HRMS.Models;

public partial class Employeemaster
{
    public int Employeeid { get; set; }

    public string Employeetype { get; set; } = null!;

    public string Employeecode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateTime Dateofbirth { get; set; }

    public string Gender { get; set; } = null!;

    public string Maritalstatus { get; set; } = null!;

    public string Bloodgroup { get; set; } = null!;

    public string? Mobileno { get; set; }

    public string? Contactno { get; set; }

    public string? Emailid { get; set; }

    public string? Refbyname { get; set; }

    public string? Refbycontactno { get; set; }

    public string Address { get; set; } = null!;

    public int Cityid { get; set; }

    public int Stateid { get; set; }

    public string Pincode { get; set; } = null!;

    public string Icefullname { get; set; } = null!;

    public string Icerelationship { get; set; } = null!;

    public string Icemobileno { get; set; } = null!;

    public string Icecontactno { get; set; } = null!;

    public DateTime Dateofjoining { get; set; }

    public int Locationid { get; set; }

    public int Deptid { get; set; }

    public int Subdeptid { get; set; }

    public int Designationid { get; set; }

    public string Shift { get; set; } = null!;

    public string Otapplicable { get; set; } = null!;

    public string Accomodation { get; set; } = null!;

    public DateTime Dateofleaving { get; set; }

    public string Leavereason { get; set; } = null!;

    public string Pfapplicable { get; set; } = null!;

    public string Pfaccnumber { get; set; } = null!;

    public DateTime Dojofpf { get; set; }

    public string Esiapplicable { get; set; } = null!;

    public string Esinumber { get; set; } = null!;

    public string Esidispensaryname { get; set; } = null!;

    public string Accounttype { get; set; } = null!;

    public string Nameasperbank { get; set; } = null!;

    public string Acccountnumber { get; set; } = null!;

    public string Ifsccode { get; set; } = null!;

    public string Branchname { get; set; } = null!;

    public string Resume { get; set; } = null!;

    public string Photo { get; set; } = null!;

    public string Pancard { get; set; } = null!;

    public string Aadharfront { get; set; } = null!;

    public string Aadharback { get; set; } = null!;

    public string Drivinglicense { get; set; } = null!;

    public DateTime Expiredate { get; set; }

    public string Status { get; set; } = null!;
}
