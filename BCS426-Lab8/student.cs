using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab8
{
    class Student
    {
        protected string name;
        protected DateTime DOB;
        protected string major;
        protected bool registered;
        protected enum Status { FRESHMEN, SOPHOMORE, JUNIOR, SENIOR};

        public Student()
        {
            name = "NO_NAME";
            DOB = DateTime.Now;
            major = "NO_NAME";
            registered = false;
        }
        public Student(string n, DateTime dob, string nmajor, bool nregistered)
        {
            name = n;
            DOB = dob;
            major = nmajor;
            registered = nregistered;
        }

        //public void newStudentArrived()
    }
}
