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
            //  EmployeeDemo();


            //Student.Initialize();
            //Student.Initialize();

            

            Student s1 = new Student();
            s1.AddStudent();
            Console.WriteLine("--------");
            Student s2 = new Student();

            s2.AddStudent();
            Console.WriteLine("--------");
            Student s3 = new Student();
            s3.AddStudent();
            
            //Student stud = new Student();
            //stud.AddStudent(); //1
            //stud.AddStudent();
            //Console.WriteLine("----------------");
            //Student s1 = new Student();
            //s1.AddStudent();
            //Student s2 = new Student();
            //s2.AddStudent();
            //stud.AddStudent(); //2
            //stud.AddStudent();  //3
            //stud.DeleteStudent(); //2
            //stud.AddStudent(); //3
            Console.ReadKey();



        }

        private static void EmployeeDemo()
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
            emp.Deptno = 100;
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
            emp1.JoiningDate = new DateTime(2019, 01, 10);
            Address address1 = new Address();
            address.StreetNo = 13;
            address.ApartmentName = "Ajay Apts";
            address.HouseNo = 456;
            address.Area = "Some Area";
            emp1.EmpAddress = address;
            emp1.Deptno = 100;
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
            Console.WriteLine("Deptname" + d.DepartmentName);
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
        }
    }
}
