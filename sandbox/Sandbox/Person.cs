internal abstract class Person
{
    public Person(string nameFirst, string nameLast, int id, DateTime inTime)
    {
        NameFirst = nameFirst;
        NameLast = nameLast;
        int ID = id;
    }
    protected string NameFirst { get; set; }
    protected string NameLast { get; set; }
    public int ID { get; set; }
    protected DateTime inTime = DateTime.Now;
    public abstract string LookUp();
}