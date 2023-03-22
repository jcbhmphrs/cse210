internal abstract class Employee : Person
{
    protected Employee(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType) : base(nameFirst, nameLast, id, inTime)
    {
        SecurityLevel = securityLevel;
        EmployeeType = employeeType;
    }
    protected int SecurityLevel { get; set; }
    protected string EmployeeType { get; set; }
}