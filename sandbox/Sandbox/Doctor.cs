internal class Doctor : Employee
{
    public Doctor(string nameFirst, string nameLast, int id, int securityLevel, string employeeType) :
    base(nameFirst, nameLast, id, securityLevel, employeeType)
    { 
    }
    private List<Patient> AssignedPatients { get; set; }
    public override string LookUp() => $"{EmployeeType}: {NameFirst} {NameLast} In Time:{InTime} #{ID} Clearance - {SecurityLevel}";
}