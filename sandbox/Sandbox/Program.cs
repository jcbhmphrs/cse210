using System;

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        bool continueLoop = true;
        int option;
        while (continueLoop)
        {
            Console.Clear();
            Console.WriteLine("1: Staff Member");
            Console.WriteLine("2: Patient");
            Console.WriteLine("3: Visitor");
            Console.WriteLine("4: View All Personnel");
            Console.Write("5: Quit\n> ");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    option = StaffOptionsDisplay();
                    switch (option)
                    {
                        case 1: hospital.StaffClockIn(); break;
                        case 2: hospital.StaffClockOut(); break;
                        case 3: hospital.LookUpById(); break;
                        default: break;
                    }
                    break;
                case 2:
                    option = PatientOptionsDisplay();
                    switch (option)
                    {
                        case 1: hospital.AdmitPatient(); break;
                        case 2: hospital.DischargePatient(); break;
                        case 3: hospital.LookUpById(); break;
                        default: break;
                    }
                    break;
                case 3:
                    option = VisitorOptionsDisplay();
                    switch (option)
                    {
                        case 1: hospital.CheckInVisitor(); break;
                        case 2: hospital.CheckOutVisitor(); break;
                        case 3: hospital.LookUpById(); break;
                        default: break;
                    }
                    break;
                case 4:
                    hospital.ViewAllPersonnel();
                    break;
                case 5:
                    continueLoop = false;
                    break;
            }
        }

        int StaffOptionsDisplay()
        {
            Console.Clear();
            Console.WriteLine("1: Clock In");
            Console.WriteLine("2: Clock Out");
            Console.WriteLine("3: Look Up By ID number");
            return int.Parse(Console.ReadLine());
        }
        int PatientOptionsDisplay()
        {
            Console.WriteLine("1: Admit");
            Console.WriteLine("2: Discharge");
            Console.WriteLine("3: Look Up By ID number");
            return int.Parse(Console.ReadLine());
        }
        int VisitorOptionsDisplay()
        {
            Console.Clear();
            Console.WriteLine("1: Check In");
            Console.WriteLine("2: Check Out");
            Console.WriteLine("3: Look Up By ID number");
            return int.Parse(Console.ReadLine());
        }


    }
}
