using System.Text.Json;
internal class Hospital
{
    private static List<Employee> staff = GenerateStaff();
    private static List<Employee> GenerateStaff()
    {
        List<Employee> personnel = new List<Employee>();
        List<Doctor> doctors = new List<Doctor>();
        using (StreamReader reader = new StreamReader("Doctors.json"))
        {
            string json = reader.ReadToEnd();
            doctors = JsonSerializer.Deserialize<List<Doctor>>(json);
            doctors.ForEach(doctor => personnel.Add(doctor));
        }

        return personnel;
    }
    public Employee GetStaffMemberByID(int id) { return staff[staff.FindIndex(employee => employee.ID == id)]; }
}