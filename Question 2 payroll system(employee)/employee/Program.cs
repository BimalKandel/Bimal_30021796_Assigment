/**
 Name= Bimal Kandel
 Student ID= 30021796
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassesExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************************");
            Console.WriteLine("*****Welcome to employee system*****");
            Console.WriteLine("************************************");
            //*Create an employee object using the constructor and populating it with the variables where we saved the employees info.
            Employee p1 = new Employee("n/a", 0, 0);

            //obtaining the detail of employee and save them to variables.
            Console.Write("\n Enter the employee name: ");
            p1.Name = Console.ReadLine();


            Console.Write("\n Please enter {0} Gross annual income: ",p1.Name);
            p1.Gross = double.Parse(Console.ReadLine());

            Console.Write("\n Please enter {0} tax rate: ",p1.Name);
            p1.Tax = double.Parse(Console.ReadLine());





            //Display the info back to the user using the empoyee object (p1)
            Console.WriteLine($"Name: {p1.Name} \nTax: {p1.Tax}%\nGross Salary: {p1.Gross}\nNet Salary: {p1.Net()}");
            Console.WriteLine("\n****************************");
            Console.WriteLine("***********THE END**********");
            Console.WriteLine("****************************");

            Console.WriteLine("Press enter to continue");

            Console.ReadLine();
        }
    }

    class Employee
    {
        //3 auto implemented properties, this is done by typing prop and pressing tab 2x
        public string Name { get; set; }
        public double Gross { get; set; }
        public double Tax { get; set; }



        //Constructor, has the same name and capitilisation as the class name.
        public Employee(string _name, double _gross, double _tax)
        {
            Name = _name;
            Tax = _tax;
            Gross = _gross;
            Console.WriteLine("************************************");
            Console.WriteLine("*******Employee record created*******");
            Console.WriteLine("************************************");
        }

        // Calculate the employee net salary after tax 
        public double Net()
        {
            return Gross * (1 - Tax / 100);
        }
    }
}


