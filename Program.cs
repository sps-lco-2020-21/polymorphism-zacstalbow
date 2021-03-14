using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            static void Test()
            {
                Person p = new Person("Zac", "Stalbow", "zac@stalbow.co.uk", "16/03/2000");
                Student s = new Student("Year 12", "Zac", "Stalbow", "zac@stalbow.co.uk", "11/03/2004");
                Teacher t = new Teacher("Computer Science", "Connor", "Mcgregor", "connor@gmail.com", "22/05/1991");
                List<Person> people = new List<Person> { p, s, t };

                foreach(Person person in people)
                {
                    person.Greet();
                    Console.WriteLine();
                    person.Describe();
                    Console.WriteLine();
                    person.Discipline();
                    Console.WriteLine();
                    Console.WriteLine($"I am an adult : {person.Adult}");
                    Console.WriteLine($"My Zodiac animal is the {person.ZodiacAnimal}");
                    Console.WriteLine($"My age is valid :  {person.Valid}");
                    Console.WriteLine($"It is my birthday : {person.Birthday}");
                    Console.WriteLine($"My screen name is : {person.ScreenName}");
                    Console.WriteLine("_________________________________________________________");
                    Console.WriteLine();
                }
            }
            Test();
        }
    }
}
