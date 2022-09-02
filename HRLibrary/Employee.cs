using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {
        int _empid;
        string _title;
       
        Address _address;

        public int Employeeid
        {
            set { _empid = value; }
            get { return _empid; }
        
        }


        private DateTime _joiningDate;

        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }


        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }

        private string  _fname;

        public string  FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        private string _lname;

        public string LastName
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public Address EmpAddress
        { 
        set{ _address = value; }
            get { return _address; }
        }

        public Employee()
        {

        }

        public Employee(int empid)
        {
            _empid = empid;
        }




    }

    public class Address
    {
        int _streetno;
        public int StreetNo
        { get { return _streetno; }
            set { _streetno = value; }
        }
        int _houseno;
        public int HouseNo
        {
            get { return _houseno; }
            set { _houseno = value; }
        }
        string _apartname;
        public string ApartmentName
        {
            get { return _apartname; }
            set { _apartname = value; }
        }
       
        string _area;
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }


        //string _city;
        //string _state;
        //long _pincode;
    
    }
}
