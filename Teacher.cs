using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Teacher : Person
    {
        protected string _subject;
        public string Subject { get { return _subject; } set { _subject = value; } }
        public Teacher(string subject, string firstName, string lastName, string emailAddress, string dateOfBirth)
        {
            _subject = subject;
            _firstName = firstName;
            _lastName = lastName;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;
        }
        public new string ScreenName()
        {
            return $"STAFF{FirstName}{LastName}{DateOFBirth}";
        }
        public override void Greet()
        {
            Console.WriteLine("Hello I am a teacher.");
        }
        public override void Describe()
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            string height = random == 1 ? "Medium" : "Tall";
            Console.WriteLine($"Name : {FirstName} {LastName} \nEmail Address : {EmailAddress} \nDate Of Birth : {DateOFBirth} \nWeight : {height} \nRole : Teacher");
        }
        public override void Discipline()
        {
            Console.WriteLine("You cannot give a teacher a detention");
        }
    }
}
