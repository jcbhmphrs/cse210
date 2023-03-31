internal class Hospital
{
    int controlId = 0;
    int id;
    Random r = new Random();
    private static List<Employee> staff = GenerateStaff();
    private static List<Employee> GenerateStaff()
    {
        //doctors
        Doctor doctor0 = new Doctor("Derek", "Shepard", 125689, 5, "Doctor");
        Doctor doctor1 = new Doctor("Gregory", "House", 125874, 4, "Doctor");
        Doctor doctor2 = new Doctor("Addison", "Montgomery", 196859, 1, "Doctor");
        Doctor doctor3 = new Doctor("Richard", "Kimball", 101055, 5, "Doctor");
        //janitors
        Janitor janitor0 = new Janitor("Susan", "McSqueaky", 158457, 2, "Janitor", "Main Floor");
        Janitor janitor1 = new Janitor("Gabrielle", "Cortesa", 139845, 2, "Janitor", "Second Floor");
        Janitor janitor2 = new Janitor("Michelle", "Jackson", 156842, 2, "Janitor", "Main Floor");
        //nurses
        Nurse nurse0 = new Nurse("Newel", "Galliard", 125648, 1, "Nurse", false);
        Nurse nurse1 = new Nurse("Pierce", "Hurley", 102103, 2, "Nurse", false);
        Nurse nurse2 = new Nurse("Hilbert", "Curves", 140562, 4, "Nurse", true);
        Nurse nurse3 = new Nurse("Haley", "Wilkinson", 177677, 3, "Nurse", true);
        List<Employee> employees = new List<Employee>()
        {doctor0, doctor1, doctor2, doctor3, janitor0, janitor1, janitor2, nurse0, nurse1, nurse2, nurse3};

        return employees;
    }
    private List<Person> hospitalPeeps = new List<Person>()
    {staff[1], staff[3], staff[6], staff[8]};
    public Employee GetStaffMemberByID(int id) { return staff[staff.FindIndex(doctor => doctor.ID == id)]; }
    public void AddToRegistry(Person person)
    {
        hospitalPeeps.Add(person);
    }
    public void RemoveFromRegistry(int id)
    {
        hospitalPeeps.RemoveAt(hospitalPeeps.FindIndex(person => person.ID == id));
    }
    public Employee AssignARandDoctor() { return staff[r.Next(staff.Count())]; }
    internal void ViewAllPersonnel()
    {
        hospitalPeeps.ForEach(person => Console.WriteLine(person.LookUp()));
        Console.ReadKey();
    }
    internal void AdmitPatient()
    {
        Console.Write("Last, First: ");
        string names = Console.ReadLine();
        string[] nameParts = names.Split(", ");
        Console.Write("Critical Status: ");
        string critStatus = Console.ReadLine();
        Patient patient = new Patient(nameParts[1], nameParts[0], GenerateTempId(), bool.Parse(critStatus), this.AssignARandDoctor());
        this.AddToRegistry(patient);
        Console.WriteLine("Patient has been admitted...");
        Console.ReadKey();
    }
    internal void DischargePatient()
    {
        Console.Write("Patient Id: ");
        id = int.Parse(Console.ReadLine());
        this.RemoveFromRegistry(id);
        Console.WriteLine("Patient has been discharged...");
        Console.ReadKey();
    }
    internal void CheckInVisitor()
    {
        Console.Write("Visitor Name; Last, First: ");
        string names = Console.ReadLine();
        string[] nameParts = names.Split(", ");
        Console.Write("Visited Patient ID: ");
        int visitedPatientID = int.Parse(Console.ReadLine());
        Patient visitingPatient = hospitalPeeps[hospitalPeeps.FindIndex(person => person.ID == visitedPatientID)] as Patient;
        if (visitingPatient == null)
        {
            Console.WriteLine($"No such patient with ID {visitedPatientID}");
        }
        else
        {
            Console.Write("Relationship to Patient: ");
            Visitor visitor = new Visitor(nameParts[1], nameParts[0], GenerateTempId(), visitingPatient, Console.ReadLine());
            this.AddToRegistry(visitor);
            Console.WriteLine("Visitor checked in...");
            Console.ReadKey();
        }
    }
    internal void CheckOutVisitor()
    {
        Console.Write("Visitor Id: ");
        id = int.Parse(Console.ReadLine());
        this.RemoveFromRegistry(id);
        Console.WriteLine("Visitor checked out...");
        Console.ReadKey();
    }
    internal void StaffClockIn()
    {
        Console.Write("Staff Id: ");
        this.AddToRegistry(GetStaffMemberByID(int.Parse(Console.ReadLine())));
        Console.WriteLine("Staff member clocked in...");
        Console.ReadKey();
    }
    internal void StaffClockOut()
    {
        Console.Write("Staff Id: ");
        this.RemoveFromRegistry(int.Parse(Console.ReadLine()));
        Console.WriteLine("Staff member clocked out...");
        Console.ReadKey();
    }
    internal void LookUpById()
    {
        Console.Write("Look up ID: ");
        id = int.Parse(Console.ReadLine());
        Console.Write(hospitalPeeps[hospitalPeeps.FindIndex(person => person.ID == id)].LookUp());
        Console.ReadKey();
    }
    internal int GenerateTempId()
    {
        string tempID = controlId < 10 ? $"0{controlId}" : $"{controlId}";
        controlId++;
        return int.Parse($"{r.Next(2000, 9999)}{tempID}");
    }
}