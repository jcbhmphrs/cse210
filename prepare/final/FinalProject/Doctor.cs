internal class Doctor : Employee
{
    public Doctor(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType, Nurse assistingNurse, List<Patient> assignedPatients) : base(nameFirst, nameLast, id, inTime, securityLevel, employeeType)
    {
        AssistingNurse = assistingNurse;
        AssignedPatients = assignedPatients;
    }
    private Nurse AssistingNurse { get; set; }
    private List<Patient> AssignedPatients { get; set; }
    public override void LookUp()
    {
        throw new NotImplementedException();
    }
}