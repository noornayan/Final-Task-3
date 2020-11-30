using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty("Tanvir Ahmed", "101");
            Faculty f2 = new Faculty("Abhijit Bhowmic", "102");
            Faculty f3 = new Faculty("Abdur Rouf", "103");
            Faculty f4 = new Faculty("Dr. Maleq", "104");
            Department d = new Department("CS", "001");
            d.AddFaculty(f1, f2, f3, f4);
            d.ShowAllFaculty();
            Console.WriteLine();
            Console.WriteLine("Deleting a Faculty");
            var faculty = d.SearchFaculty("102");
            if (faculty != null)
            {
                d.DeleteFaculty(faculty);
            }
            d.ShowAllFaculty();
        }
    }
}
