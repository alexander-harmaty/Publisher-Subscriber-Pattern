using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab8
{
    class Program
    {
        enum Status
        {
            FRESHMEN,
            SOPHOMORE,
            JUNIOR,
            SENIOR
        }
        static void Main(string[] args)
        {
            Registrar registrar = new Registrar();



            //var student1 = new Student();
            //var registrar = new Registrar();
            //student1.NewStudentInfo += registrar.NewStudentIsHere;
            //student1.NewStudent("student1");

            /** Prof-CarExample
            var dealer = new CarDealer();
            var valtteri = new Consumer("Valtteri");
            dealer.NewCarInfo += valtteri.NewCarIsHere;
            dealer.NewCar("Williams");

            var max = new Consumer("Max");
            dealer.NewCarInfo += max.NewCarIsHere;
            dealer.NewCar("Mercedes");

            dealer.NewCarInfo -= valtteri.NewCarIsHere;
            dealer.NewCar("Ferrari");

            Console.ReadLine(); 
            **/
        }

        //create a new student every N milliseconds 
        //     where N is a random number between (100-3000). 
        //You can use Random class to create a random number 
        //     and Thread.Sleep method to pause your main program 
        //     in between a new student creations
        //Create at least 3 new students with appropriate data of your choice 
        //     (name, date of birth, status, …). 
        //     Note that the registered feature of each student is initially false. 
        //After creation, each student will fire the newStudentArrived method 
        //     to be handled by the registrar.
        //Make sure to add appropriate outputs to your main program that show the user 
        //     the order of events and how the events are handled.

    }
}
