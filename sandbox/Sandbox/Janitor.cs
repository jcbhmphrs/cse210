internal class Janitor : Employee
{
    public Janitor(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType, string contractor) : base(nameFirst, nameLast, id, inTime, securityLevel, employeeType)
    {
        Contractor = contractor;
    }
    private string Contractor { get; set; }

    public override string LookUp()
    {
        throw new NotImplementedException();
    }
}