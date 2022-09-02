using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace ObjectOrientedAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101);
            //emp.Employeeid = 101;
            emp.Title = "Dr.";
            emp.FirstName = "Anisha";
            emp.LastName = "K";
            emp.EmpAddress.StreetNo = 12;
            emp.EmpAddress.ApartmentName = "ABC";
            emp.EmpAddress.HouseNo = 101;
            emp.EmpAddress.Area = "HHH";
            emp.JoiningDate = new DateTime(2022, 06, 11);
            Console.WriteLine(emp.Employeeid);
            Console.ReadKey();



        }
    }
}
