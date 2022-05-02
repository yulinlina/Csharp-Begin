using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string name;
        public string major;
        private double gpa;
        public static int stucont = 0;
        public Student(string aname,string amajor, double agpa)
        {
            name = aname;
            major = amajor;
            Gpa = agpa;
            stucont++;
        } 
        public bool hasHonor()
        {
            return true;
        }
        public double Gpa
        {
            get { return gpa; }
            set {
                if (value <= 4.0)
                    gpa = value;
                else
                    Console.WriteLine("ilegal change of gpa");
            }
        }
    }
}
