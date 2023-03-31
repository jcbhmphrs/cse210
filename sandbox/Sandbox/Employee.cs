internal abstract class Employee : Person
{
    protected Employee(string nameFirst, string nameLast, int id, int securityLevel, string employeeType) : base(nameFirst, nameLast, id)
    {
        SecurityLevel = securityLevel;
        EmployeeType = employeeType;
        ID = id;

    }
    protected int SecurityLevel { get; set; }
    public string EmployeeType { get; set; }
}