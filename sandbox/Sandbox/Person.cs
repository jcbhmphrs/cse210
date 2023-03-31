internal abstract class Person
{
    public Person(string nameFirst, string nameLast, int id = 0)
    {
        NameFirst = nameFirst;
        NameLast = nameLast;
        ID = id;
    }
    public int ID { get; set; }
    public string NameFirst { get; set; }
    public string NameLast { get; set; }
    protected DateTime inTime = DateTime.Now;
    protected string InTime {get => inTime.ToString("MM/dd/yy HH:mm:ss");}
    public abstract string LookUp();
}