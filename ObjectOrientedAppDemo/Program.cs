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
           
            Address address = new Address();
            address.StreetNo = 12;
            address.ApartmentName = "Atul Apts";
            address.HouseNo = 123;
            address.Area = "Atul Area";
            emp.EmpAddress = address;
            emp.JoiningDate = new DateTime(2022, 06, 11);
            Console.WriteLine(emp.Employeeid);
            Console.WriteLine(emp.Title);
            Console.WriteLine(emp.FirstName);
            Console.WriteLine(emp.LastName);
            Console.WriteLine("--------");
            //int eid=emp.Employeeid;
            //Console.WriteLine(eid);
            Console.WriteLine("employee address as follows");
            Console.WriteLine(emp.EmpAddress.StreetNo);
            Console.WriteLine(emp.EmpAddress.ApartmentName);
            Console.WriteLine(emp.EmpAddress.HouseNo);
            Console.WriteLine(emp.EmpAddress.Area);


            Employee emp1 = new Employee();
            emp1.Employeeid = 102;
            emp1.Title = "Mr";
            emp1.FirstName = "Keshav";
            emp1.LastName = "P";
            emp1.JoiningDate = new DateTime(2019,01,10);
            Address address1 = new Address();
            address.StreetNo = 13;
            address.ApartmentName = "Ajay Apts";
            address.HouseNo =456;
            address.Area = "Some Area";
            emp1.EmpAddress = address;

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp);
            emplist.Add(emp1);

            Console.WriteLine("-------One Dept many employees-------");
            Dept d = new Dept();
            d.Deptnumber = 100;
            d.DepartmentName = "Research";
            d.Location = "Hyderabad";
            d.DeptEmployees = emplist;


            Console.WriteLine("Dept details");
            Console.WriteLine("Deptno= " + d.Deptnumber);
            Console.WriteLine("Deptname"  + d.DepartmentName);
            Console.WriteLine("Location of Dept=" + d.Location);
            foreach (var item in d.DeptEmployees)
            {
                Console.WriteLine(item.Employeeid);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.JoiningDate);
                Console.WriteLine(item.EmpAddress.StreetNo);
                Console.WriteLine(item.EmpAddress.HouseNo);
                Console.WriteLine(item.EmpAddress.ApartmentName);
                Console.WriteLine(item.EmpAddress.Area);
                Console.WriteLine("--------------------------");
            }





            Console.ReadKey();



        }
    }
}
