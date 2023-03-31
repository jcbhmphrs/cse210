internal class Nurse : Employee
{
    public Nurse(string nameFirst, string nameLast, int id, int securityLevel, string employeeType, bool certified) : base(nameFirst, nameLast, id, securityLevel, employeeType)
    {
        Certified = certified;
    }
    private bool Certified { get; set; }

    public override string LookUp() => $"{EmployeeType}: {NameFirst} {NameLast} In Time:{InTime} #{ID} Clearance - {SecurityLevel} Cert.({Certified})";
}