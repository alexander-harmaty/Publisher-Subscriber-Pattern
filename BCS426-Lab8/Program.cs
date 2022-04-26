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
        //Create at least 3 new students
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
                "Jacquelyn Vazquez", "Alondra Kirby", "Ashly Mays", "Carmen Frost", "Alivia Sheppard" };                             //list of names to choose from
            string[] majors = {"Logic", "Journalism", "Communication", "Mathematics", "Computer Sciences",
                "Archaeology", "Earth Sciences", "Chemistry", "Medicine", "Sociology",
                "Chemical Engineering", "Psychology", "Business", "Political Science", "Engineering",
                "Biology", "Philosophy", "Education", "Economics", "Geography"};                            //list of majors to choose from
            DateTime randDate() 
            {
                int year = rand.Next(1980, DateTime.Now.Year);
                int month = rand.Next(1, 12);
                int day = rand.Next(1, 28);
                int hour = rand.Next(0, 23);
                int min = rand.Next(0, 59);
                int sec = rand.Next(0, 59);

                return new DateTime(year, month, day, hour, min, sec);
            }                           //random date generator
            Status randStatus = (Status)rand.Next(0, 3);     //random status generator
            TimeSpan N = new TimeSpan(rand.Next(100, 3000)); //where N is a random number 100-3000.

            //Create registrar and student objects
            Registrar registrar = new Registrar();
            Student[] students = new Student[numOfStudents];
                        
            for (int i = 0; i < numOfStudents; i ++)
            {
                students[i] = new Student();
                students[i].NewStudentInfo += registrar.NewStudentArrived;
                students[i].NewStudent(names[rand.Next(names.Length)], randDate(), majors[rand.Next(majors.Length)], randStatus, false);
                Console.WriteLine(students[i].ToString());
                //create a new student every N milliseconds
                Thread.Sleep(N);
            }

            Console.WriteLine("\nPress any key to exit program");
            Console.ReadLine();
        }
    }
}
