internal class Visitor : Person
{
    public Visitor(string nameFirst, string nameLast, int id, DateTime inTime, Patient patientVisiting, string relationship) : base(nameFirst, nameLast, id, inTime)
    {
        PatientVisiting = patientVisiting;
        Relationship = relationship;
    }
    private Patient PatientVisiting { get; set; }
    private string Relationship { get; set; }
    public override void LookUp()
    {
        throw new NotImplementedException();
    }
}