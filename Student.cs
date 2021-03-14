using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Student : Person
    {
        string _schoolYear;
        public string SchoolYear { get { return _schoolYear; } set { _schoolYear = value ; } }
        public Student(string schoolYear, string firstName, string lastName, string emailAddress, string dateOfBirth)
        {
            _schoolYear = schoolYear;
            _firstName = firstName;
            _lastName = lastName;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;
        }

        public Student(string firstName, string lastName, string emailAddress, string dateOfBirth)
        {
            int year = Age() - 5;
            _schoolYear = $"Year {year}";
            if (Age() == 4)
            {
                _schoolYear = "Reception";
            }
            if (Age() < 4)
            {
                _schoolYear = "Nursery";
            }
            if (Age() < 2)
            {
                _schoolYear = "Not in school";
            }
            _firstName = firstName;
            _lastName = lastName;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;
        }
        public new string ScreenName()
        {
            return $"{FirstName}{LastName}{DateOFBirth}";
        }
        public override void Greet()
        {
            Console.WriteLine("Hello I am a student.");
        }
        public override void Describe()
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            string height = random == 1 ? "Short" : "Medium";
            Console.WriteLine($"Name : {FirstName} {LastName} \nEmail Address : {EmailAddress} \nDate Of Birth : {DateOFBirth} \nWeight : {height} \nRole : Student");
        }
        public override void Discipline()
        {
            Console.WriteLine($"{_firstName} {_lastName} has received a detention");
        }
    }
}
