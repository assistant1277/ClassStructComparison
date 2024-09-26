using ClassStruct.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The features of Class and Struct are \n");
            //class example
            DisplayTypeExample("1) Type: \n");

            DisplayClassOrStruct("Class example:");
            Console.WriteLine("Class is Reference Type ");
            People person1 = new People("raj", 40);
            People person2 = person1;

            person2.name = "raju";

            PrintPersonNames(person1, person2);
            Console.WriteLine();

            // Struct example
            DisplayClassOrStruct("Struct example:");

            Console.WriteLine("Struct is Value Type ");
            Rectangle rectangle1 = new Rectangle(10, 20);
            Rectangle rectangle2 = rectangle1;

            rectangle2.width = 50;
            PrintRectangleWidths(rectangle1, rectangle2);
            Console.WriteLine();

            // Class example for inheritance
            DisplayTypeExample("2) Inheritance: \n");

            DisplayClassOrStruct("Class example:");
            Employee employee1 = new Employee("rahul", 30, "software engineer");
            Employee employee2 = employee1;
            employee2.name = "raju";

            PrintEmployeeInfo(employee1, employee2);
            Console.WriteLine();

            // Struct example for inheritance
            DisplayClassOrStruct("Struct example:");
            Console.WriteLine("No inheritance: Structs cannot inherit from other structs or classes");
            Console.WriteLine();

            // Class example for default constructor
            DisplayTypeExample("3) Default Constructor: \n");

            DisplayClassOrStruct("Class example:");
            People person11 = new People();
            person11.DisplayDetails();

            People person12 = new People("ram", 30);
            person12.DisplayDetails();
            Console.WriteLine();

            DisplayClassOrStruct("Struct example:");
            Rectangle rectangle11 = new Rectangle();
            rectangle11.DisplayDetails();

            Rectangle rectangle12 = new Rectangle(10, 20);
            rectangle12.DisplayDetails();
            Console.WriteLine();

            // Class example for nullability
            DisplayTypeExample("4) Nullability: \n");

            DisplayClassOrStruct("Class example:");
            People person112 = new People("ram", 25);
            Console.WriteLine("person1 name " + person112.name);

            person112 = null;
            if (person112 == null)
            {
                Console.WriteLine("person1 is null");
            }

            Console.WriteLine();

            DisplayClassOrStruct("Struct example:");
            Rectangle rectangle112 = new Rectangle(10, 20);
            Console.WriteLine($"rectangle1 width {rectangle1.width}, height: {rectangle112.length}");

            Rectangle ?rectangle122 = new Rectangle(5, 15);
            Console.WriteLine($"rectangle2 width {rectangle122?.width}, height: {rectangle122?.length}");
            rectangle122 = null;

            if (rectangle122 == null)
            {
                Console.WriteLine("rectangle2 is null");
            }

            Console.WriteLine();

            // Copy behaviour functionality
            DisplayTypeExample("5) Copy behaviour \n");

            DisplayClassOrStruct("Class example:");
            People person18 = new People("rohit");
            People person19 = person18;

            PrintPersonNames(person18, person19, "before modification");
            person19.name = "rahul";
            PrintPersonNames(person18, person19, "\nafter modification");
            Console.WriteLine();

            DisplayClassOrStruct("Struct example:");
            Rectangle rectangle98 = new Rectangle(10, 20);
            Rectangle rectangle99 = rectangle98;

            PrintRectangleDimensions(rectangle98, rectangle99, "before modification");
            rectangle99.width = 15;
            PrintRectangleDimensions(rectangle98, rectangle99, "\nafter modification");

            Console.ReadKey();
        }

        static void DisplayTypeExample(string message)
        {
            Console.WriteLine(message);
        }

        static void DisplayClassOrStruct(string value)
        {
            Console.WriteLine(value);
        }
        static void PrintPersonNames(People person1, People person2, string context = "")
        {
            if (!string.IsNullOrEmpty(context))
            {
                Console.WriteLine(context);
            }
            Console.WriteLine("person1 name " + person1.name);
            Console.WriteLine("person2 name " + person2.name);
        }
        static void PrintRectangleWidths(Rectangle rectangle1, Rectangle rectangle2)
        {
            Console.WriteLine("rect1 width " + rectangle1.width);
            Console.WriteLine("rect2 width " + rectangle2.width);
        }
        static void PrintEmployeeInfo(Employee emp1, Employee emp2)
        {
            Console.WriteLine("employee 1 details");
            emp1.DisplayEmployeeDetails();

            Console.WriteLine("\nemployee 2 details");
            emp2.DisplayEmployeeDetails();
        }
        static void PrintRectangleDimensions(Rectangle rectangle1, Rectangle rectangle2, string context = "")
        {
            if (!string.IsNullOrEmpty(context))
            {
                Console.WriteLine(context);
            }
            Console.WriteLine($"rectangle1 Width {rectangle1.width}, height: {rectangle1.length}");
            Console.WriteLine($"rectangle2 Width {rectangle2.width}, height: {rectangle2.length}");
        }

    }
}

