internal class Nurse : Employee
{
    public Nurse(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType, bool certified) : base(nameFirst, nameLast, id, inTime, securityLevel, employeeType)
    {
        Certified = certified;
    }
    private bool Certified { get; set; }

    public override string LookUp()
    {
        throw new NotImplementedException();
    }
}