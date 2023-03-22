internal class Patient : Person
{
    public Patient(string nameFirst, string nameLast, int id, DateTime inTime, bool criticalStatus, Doctor assignedDoctor) : base(nameFirst, nameLast, id, inTime)
    {
        CriticalStatus = criticalStatus;
        AssignedDoctor = assignedDoctor;
    }
    private bool CriticalStatus { get; set; }
    private Doctor AssignedDoctor { get; set; }
    public override string LookUp()
    {
        throw new NotImplementedException();
    }
}