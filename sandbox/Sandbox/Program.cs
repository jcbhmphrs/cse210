using System;

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        Console.Write(hospital.GetStaffMemberByID(256875).LookUp());
    }
}
//         bool continueLoop = true;
//         int option;
//         while (continueLoop)
//         {

//             Console.Clear();
//             Console.WriteLine("1: Staff Member");
//             Console.WriteLine("2: Patient");
//             Console.WriteLine("3: Visitor");
//             Console.Write("Quit\n\n> ");

//             switch (int.Parse(Console.ReadLine()))
//             {
//                 case 1:
//                     option = StaffOptionsDisplay();
//                     switch (option)
//                     {
//                         case 1:
//                             Console.WriteLine("Staff member has been checked in...");
//                             Console.ReadKey();
//                             break;
//                         case 2:
//                             Console.WriteLine("Staff member has been checked out...");
//                             Console.ReadKey();
//                             break;
//                         default:
//                             break;
//                     }
//                     break;
//                 case 2:
//                     option = PatientOptionsDisplay();
//                     switch (option)
//                     {
//                         case 1:
//                             Console.WriteLine("Patient has been admitted...");
//                             Console.ReadKey();
//                             break;
//                         case 2:
//                             Console.WriteLine("Patient has been discharged...");
//                             Console.ReadKey();
//                             break;
//                         default:
//                             break;
//                     }
//                     break;
//                 case 3:
//                     option = VisitorOptionsDisplay();
//                     switch (option)
//                     {
//                         case 1:
//                             Console.WriteLine("Visitor has been checked in...");
//                             Console.ReadKey();
//                             break;
//                         case 2:
//                             Console.WriteLine("Visitor has been checked out...");
//                             Console.ReadKey();
//                             break;
//                         default:
//                             break;
//                     }
//                     break;
//                 case 4:
//                     continueLoop = false;
//                     break;
//             }
//         }

//         int StaffOptionsDisplay()
//         {
//             Console.Clear();
//             Console.WriteLine("1: Check In");
//             Console.WriteLine("2: Check Out");
//             return int.Parse(Console.ReadLine());
//         }
//         int PatientOptionsDisplay()
//         {
//             Console.WriteLine("1: Admit");
//             Console.WriteLine("2: Discharge");
//             return int.Parse(Console.ReadLine());
//         }
//         int VisitorOptionsDisplay()
//         {
//             Console.Clear();
//             Console.WriteLine("1: Check In");
//             Console.WriteLine("2: Check Out");
//             return int.Parse(Console.ReadLine());
//         }



//     }
// }