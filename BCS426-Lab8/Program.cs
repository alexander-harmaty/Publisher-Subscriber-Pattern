using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BCS426_Lab8
{
    class Program
    {
        public static int numOfStudents = 3;
        public static int studentIterator = 0;

        enum Status
        {
            FRESHMEN,
            SOPHOMORE,
            JUNIOR,
            SENIOR
        }
        public static void Main(string[] args)
        {
            //Randoms
            Random rand = new Random();
            string[] names = {"Jaycee Heath", "Luka Bailey", "Precious Brady", "Juliet Mcpherson", "Cullen Knight",
                "Alex Sherman", "Livia Williamson", "Mya Shah", "Brenton Mckinney", "Camille Snyder",
                "Carlo Little", "Amara Thompson", "Ricky Burke", "Phillip Booker", "Laylah Foley",
                "Leonel Mckenzie", "Moriah Riley", "Cassandra Haney", "Abbey Kelley", "Billy Doyle",
                "Yazmin Duarte", "Jeffrey Barnes", "Sophia Mullen", "Elsie Grant", "Lindsey Collins",
                "Teagan Mccarthy", "Holly Poole", "Makenzie Shepard", "Molly Stevens", "Kody Riggs",
                "Isis Conrad", "Harper Massey", "Christina Werner", "Breanna Stanton", "Kailee Woodard",
                "Roy Price", "Hailee Fletcher", "Audrey Turner", "Troy Ayala", "Campbell Curtis",
                "Isabella Lucero", "Liberty Contreras", "Thaddeus Richards", "Jaydin Decker", "Alisa Warren",
                "Jacquelyn Vazquez", "Alondra Kirby", "Ashly Mays", "Carmen Frost", "Alivia Sheppard" };     //list of names to choose from
            string[] majors = {"Logic", "Journalism", "Communication", "Mathematics", "Computer Sciences",
                "Archaeology", "Earth Sciences", "Chemistry", "Medicine", "Sociology",
                "Chemical Engineering", "Psychology", "Business", "Political Science", "Engineering",
                "Biology", "Philosophy", "Education", "Economics", "Geography"};    //list of majors to choose from

            DateTime randDate = new DateTime(       //random date generator
                rand.Next(1980, DateTime.Now.Year),     //year
                rand.Next(1, 12),                       //month
                rand.Next(1, 28));                      //day
            Status randStatus = (Status)rand.Next(0, 3);    //random status generator

            //Create registrar and student objects
            Registrar registrar = new Registrar();
            Student[] students = new Student[numOfStudents];

            //create a new student every N milliseconds where N is a random number 100-3000.
            TimeSpan N = new TimeSpan(rand.Next(100, 3000)); 

            for (int i = 0; i < numOfStudents; i ++)
            {
                //Create at least 3 new students where the 'registered' for each is false.
                students[i] = new Student();
                students[i].NewStudentInfo += registrar.NewStudentArrived;
                students[i].NewStudent(names[rand.Next(names.Length)], randDate, majors[rand.Next(majors.Length)], randStatus, false);
                Thread.Sleep(N);
            }

            Console.ReadLine();

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

        
        //You can use Random class to create a random number 
        //     and Thread.Sleep method to pause your main program 
        //     in between a new student creations
        
        //After creation, each student will fire the newStudentArrived method 
        //     to be handled by the registrar.
        //Make sure to add appropriate outputs to your main program that show the user 
        //     the order of events and how the events are handled.

    }
}
