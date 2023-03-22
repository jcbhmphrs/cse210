internal class Doctor : Employee
{
    public Doctor(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType, List<Patient> assignedPatients) : base(nameFirst, nameLast, id, inTime, securityLevel, employeeType)
    {
        AssignedPatients = assignedPatients;
    }
    private List<Patient> AssignedPatients { get; set; }
    public override string LookUp()
    {
        return $"{NameFirst} {NameLast} {ID} {SecurityLevel}";
    }
}