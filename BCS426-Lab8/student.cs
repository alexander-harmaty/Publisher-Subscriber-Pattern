using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab8
{
    public class StudentInfoEventArgs : EventArgs
    {
        public string name { get; set; }
        public DateTime DOB { get; set; }
        public string major { get; set; }
        public bool registered { get; set;}
        public Enum Status { get; set;}

        public StudentInfoEventArgs(string studentName)
        {
            name = studentName;
            DOB = DateTime.Now;
            major = "NO_NAME";
            //status
            registered = false;
        }

        public StudentInfoEventArgs(string nname, DateTime ndob, string nmajor, Enum nstatus, bool nregistered)
        {
            name = nname;
            DOB = ndob;
            major = nmajor;
            Status = nstatus;
            registered = nregistered;
        }

        public override string ToString() => "New Student!" +
            $"\tName:{name}\tDoB:{DOB}\tMajor:{major}\tStatus:{Status}\tEnrolled?:{registered}";

        
    }

    public class Student //publisher-producer
    {
        public event EventHandler<StudentInfoEventArgs> NewStudentInfo;

        public void NewStudent(string name, DateTime dob, string major, Enum status, bool registered)
        {
            Console.WriteLine("New Student!" +
                $"\tName:{name}\tDoB:{dob}\tMajor:{major}\tStatus:{status}\tEnrolled?:{registered}");

            NewStudentInfo?.Invoke(this, new StudentInfoEventArgs(name, dob, major, status, true));
        }
    }

    //Event newStudentArrived event will be fired 
    //     to be handled by the consumer class Registrar 
    //    (depending on your design you can add this capability 
    //   to class Student or to another class that you see fit)

    /**Prof-CarExample
    public class CarInfoEventArgs : EventArgs
    {
        public CarInfoEventArgs(string car) => Car = car;

        public string Car { get; }
    }

    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            Console.WriteLine($"CarDealer, new car {car}");

            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));
        }
    }
    **/

}
