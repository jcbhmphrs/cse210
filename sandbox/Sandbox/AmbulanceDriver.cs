internal class AmbulanceDriver : Employee
{
    public AmbulanceDriver(string nameFirst, string nameLast, int id, DateTime inTime, int securityLevel, string employeeType, Patient patientTransported, int driversNumber) : base(nameFirst, nameLast, id, inTime, securityLevel, employeeType)
    {
        PatientTransported = patientTransported;
        DriversNumber = driversNumber;
    }
    private Patient PatientTransported { get; set; }
    private int DriversNumber { get; set; }

    public override string LookUp()
    {
        throw new NotImplementedException();
    }
}