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

        public Registrar()
        {
            _name = "Registrar";
        }
        public Registrar(string name)
        {
            _name = name;
        }

        //When a new student arrives, the registrar will take the student info... 
        public void NewStudentArrived(object sender, StudentInfoEventArgs e)
        {
            //update the registered field for the student to true 
            e.registered = true; 
            
            Console.WriteLine($"Update!: Student {e.name} has been registered\n");
        }
    }     

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
