// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Math;
using System;
namespace HelloWorld
{
    public enum shippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Person1
    {
        public int Age;
    }
    public class Person2 { 
        public string Name;
    }
    class Program
    {
        static void Main(String[] args)
        {
            var method = shippingMethod.Express;
            Console.WriteLine((int)method);

            var secMethod= shippingMethod.RegularAirMail;

            Console.WriteLine(secMethod.ToString());

            //var methodId = 2;
            //Console.WriteLine((shippingMethod)methodId);
            //var methodName = "Express";
            //var shippingMethod= (shippingMethod)Enum.Parse(typeof(shippingMethod), methodName);
            var a = 10;
            var b = a;
            b++;
            var c = b;
            ++a;
            Console.WriteLine(string.Format("a:{0}, b:{1} ,c:{2}", a, b, c));
        

            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Dolh";
            person.Introduce();

            Calculator calculator = new Calculator();
            int result=calculator.Add(2, 4);
            Console.WriteLine(result);

            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names=new string[3]{"jack","mary","john" };
            var allNames=string.Join(" ", names);
            Console.WriteLine(allNames);

            var person1=new Person1() { Age=20};
            MakeOld(person1);
            Console.WriteLine(person1.Age);
            var number = 2;
            Increment(number);
            Console.WriteLine(number);

            var testName = new Person2() ;
            MakeNew(testName);
            Console.WriteLine(testName.Name);
            

        }
        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }
        public static void MakeOld(Person1 person)
        {
            person.Age += 5;
        }
        public static void MakeNew(Person2 person) { 
            person.Name = "Test";
        }
    }
}

