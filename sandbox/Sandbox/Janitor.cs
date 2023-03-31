internal class Janitor : Employee
{
    public Janitor(string nameFirst, string nameLast, int id, int securityLevel, string employeeType, string assignedFloor) : base(nameFirst, nameLast, id, securityLevel, employeeType)
    {
        AssignedFloor = assignedFloor;
    }
    private string AssignedFloor { get; set; }

    public override string LookUp() => $"{EmployeeType}: {NameFirst} {NameLast} In Time:{InTime} #{ID} Clearance - {SecurityLevel}. flr ({AssignedFloor})";
}
