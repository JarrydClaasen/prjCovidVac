using System;

namespace prjCovidVac
{
    class Program
    {
        static void Main(string[] args)
        {
            Information i = new Information();

            Console.Write("Please enter the hospital's name:");
            i.setHospital_Name(Console.ReadLine());

            Console.Write("Please enter if the hospital is Public or Private: ");
            i.setHospitalType(Console.ReadLine());

            Console.Write("Please enter the address: ");
            i.setAddress(Console.ReadLine());

            Console.Write("Please enter the hospital's province :");
            i.setProvince(Console.ReadLine());

            Console.Write("Please enter the hospital's province :");
            i.setArray(Convert.ToChar(Console.ReadLine()));

            Capture c = new Capture();

            c.GetPatientInformation();


        }
    }
}

