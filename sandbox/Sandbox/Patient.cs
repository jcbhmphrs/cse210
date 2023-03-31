internal class Patient : Person
{
    public Patient(string nameFirst, string nameLast, int id, bool criticalStatus, Employee assignedDoctor) : base(nameFirst, nameLast, id)
    {
        CriticalStatus = criticalStatus;
        AssignedDoctor = assignedDoctor;
        
    }
    private bool CriticalStatus { get; set; }
    private Employee AssignedDoctor { get; set; }
    public override string LookUp() => $"Patient: {NameLast}, {NameFirst} | In Time:{InTime} | #{ID} | Assigned to {AssignedDoctor.EmployeeType} {AssignedDoctor.NameLast} | Critical Condition({CriticalStatus})";
}