using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab8
{
    public class Student //publisher-producer
    {
        string name;
        DateTime DOB;
        string major;
        bool registered;
        enum Status { FRESHMEN, SOPHOMORE, JUNIOR, SENIOR};

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

        public void newStudentArrived()
        {

        }

        /**
         * Event newStudentArrived event will be fired 
         *      to be handled by the consumer class Registrar 
         *      (depending on your design you can add this capability 
         *      to class Student or to another class that you see fit)
        **/
    }
}
