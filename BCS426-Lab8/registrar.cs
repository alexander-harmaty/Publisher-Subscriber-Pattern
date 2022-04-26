using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab8
{
    public class Registrar //subscriber-consumer
    {
        public string _name;
        public Student[] studentList;

        public Registrar()
        {
            _name = "Registrar";
            studentList = null;
        }
        public Registrar(string name)
        {
            _name = name;
            studentList = null;
        }

        public void NewStudentIsHere(object sender, StudentInfoEventArgs e) =>
            Console.WriteLine($"{_name}:");
    }

    //When a new student arrives, 
    //      the registrar will take the student info, 
    //      update the registered field for the student to true and place 
    //      (that is save) the student info  in the student list.

    /**Prof-CarExample
    public class Consumer
    {
        private string _name;

        public Consumer(string name) => _name = name;

        public void NewCarIsHere(object sender, CarInfoEventArgs e) =>
          Console.WriteLine($"{_name}: car {e.Car} is new");
    }
    **/

}
