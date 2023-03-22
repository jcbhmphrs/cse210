internal abstract class Employee : Person
{
    protected Employee(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType) : base(nameFirst, nameLast, id, inTime)
    {
        SecurityLevel = securityLevel;
        EmployeeType = employeeType;
    }
    private int SecurityLevel { get; set; }
    private string EmployeeType { get; set; }
}