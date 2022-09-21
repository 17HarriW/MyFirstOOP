using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new Student();
            alice.name = "Alice";
            alice.age = 15;
            bob.name = "Bob";
            bob.age = 17;
            bob.toggleAtSchool();
            alice.showInfo();
            bob.showInfo();
            
            Console.ReadLine();
        }
    }

    class Student
    {
        public string name;
        public int age;
        private bool atSchool = false;

        public void showInfo()
        {
            Console.WriteLine(name + ", " + age);
        }
        public void toggleAtSchool()
        {
            atSchool = !(atSchool);
        }
        public bool getAtSchool()
        {
            return atSchool;
        }
    }
}
