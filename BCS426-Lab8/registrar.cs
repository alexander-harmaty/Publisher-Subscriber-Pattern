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
        
        public void NewStudentArrived(object sender, StudentInfoEventArgs e)
        {
            //update the registered field for the student to true 
            e.registered = true; 
            
            Console.WriteLine($"Update!: Student {e.name} has been registered.");
        }
    }
}
