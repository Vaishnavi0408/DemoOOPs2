using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPs2
{
    interface ICalculator
    {
        void add(int a, int b);
        void multiply(int a, int b);
    }
    class CasioCalculator : ICalculator
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Sum="+(a+b));
        }

        public void multiply(int a, int b)
        {
            Console.WriteLine("Product="+a*b);
        }
    }
    abstract class Teacher
    {
        string name;
        string qualification;
        int experience;

        protected Teacher(string name, string qualification, int experience)
        {
            this.name = name;
            this.qualification = qualification;
            this.experience = experience;
        }

        public int Experience { get => experience; set => experience = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Name { get => name; set => name = value; }

        public abstract void CalculateSalary();
        public override string ToString()
        {
            return $"Name={name} qualification={qualification} experience={experience}";
        }

    }

    class VisitingTeacher : Teacher
    {
        int hrs, rate;

        public VisitingTeacher(string name, string qualification, int experience,int hrs,int rate) : base(name, qualification, experience)
        {
            this.hrs = hrs;
            this.rate = rate;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("Salary="+hrs*rate);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Teacher t1 = new VisitingTeacher("Deepa", "BE", 15, 50, 1000);
            t1.CalculateSalary();
        }
    }
    
}
