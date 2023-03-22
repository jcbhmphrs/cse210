internal class Nurse : Employee
{
    public Nurse(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType, Doctor reportingDr) : base(nameFirst, nameLast, id, inTime, securityLevel, employeeType)
    {
        ReportingDr = reportingDr;
    }
    private Doctor ReportingDr { get; set; }

    public override void LookUp()
    {
        throw new NotImplementedException();
    }
}