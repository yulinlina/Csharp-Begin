// See https://aka.ms/new-console-template for more information
using System;


namespace ConsoleApp1
{
    class Program
    { 
        public int Findmax(int a,int b)
        {
            return a > b ? a : b;
        }
    }
    class Test
    {
        static void Main()
        {
            string characterName = "yulin";
            int age = 20;
            Console.WriteLine("There was a person named " + characterName);
            Console.WriteLine("Hello, World!");
            Console.WriteLine("age is  " + age);

          //  int num = Convert.ToInt16(Console.ReadLine());
          //  Console.WriteLine("num is " + num);
            Program h = new Program();
            int res = h.Findmax(2, 5);
            Console.WriteLine("res is " + res);

            Book book1 = new Book("yulin", "yulinlin", 400);
            Console.WriteLine(book1.title);


            Student student1 = new Student("yu", "cs", 4.0);
            if (student1.hasHonor())
                Console.WriteLine("Congraluation!");

            // setter and getter
            student1.Gpa = 5;
            Console.WriteLine("gpa:" + student1.Gpa);

            // static variable about class 
            Console.WriteLine("counter of students: "+Student.stucont);

            // staic method
            UsefulTools.Sayhello("yulinlin");

            // vitural and override
            Chef chef1 = new Mychef();
            chef1.makeSpecial();

        }
    }
}