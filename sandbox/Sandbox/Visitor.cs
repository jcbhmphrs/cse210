internal class Visitor : Person
{
    public Visitor(string nameFirst, string nameLast, int id, Person patientVisiting, string relationship) : base(nameFirst, nameLast, id)
    {
        PatientVisiting = patientVisiting;
        Relationship = relationship;
    }
    private Person PatientVisiting { get; set; }
    private string Relationship { get; set; }
    public override string LookUp() => $"Visitor: {NameLast}, {NameFirst} | In Time:{InTime} | #{ID} | Visiting - {PatientVisiting.NameLast +", "+ PatientVisiting.NameFirst} Rel({Relationship})";
}