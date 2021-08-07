using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            Console.WriteLine("emp.GetHashCode: " + emp.GetHashCode());
            Console.WriteLine("emp.GetType: " + emp.GetType());
            Console.WriteLine("emp.ToString: " + emp.ToString());

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;
            Console.WriteLine("hourEmp.GetHashCode: " + hourEmp.GetHashCode());
            Console.WriteLine("hourEmp.GetType: " + hourEmp.GetType());
            Console.WriteLine("hourEmp.ToString: " + hourEmp.ToString());
            Console.ReadLine();
            Object athing = hourEmp;
            Console.WriteLine("hourEmp.ToString: " + athing);
            HourlyEmployee unboxedEmp = (HourlyEmployee)athing;
            Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            /*SalaryEmployee unboxedEmp = (SalaryEmployee)athing;
            Console.WriteLine("First Name: " + unboxedEmp.FirstName);*/
            if (athing is HourlyEmployee)
            {
                //Unboxing
                HourlyEmployee athing1 = (HourlyEmployee)athing;
                Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            }

            if (athing is HourlyEmployee)
            {
                //Unboxing
                SalaryEmployee athing1 = (SalaryEmployee)athing;
                Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            }





        }
    }
}
