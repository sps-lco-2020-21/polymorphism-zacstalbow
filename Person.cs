using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Inheritance
{
    public class Person : AbstractPerson
    {
        protected string _firstName;
        protected string _lastName;
        protected string _emailAddress;
        protected string _dateOfBirth; // formatted xx/xx/xxxx
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string EmailAddress { get { return _emailAddress; } set { _emailAddress = value; } }
        public string DateOFBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public Person(string firstName, string lastName, string emailAddress, string dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _emailAddress = emailAddress;
            _dateOfBirth = dateOfBirth;
        }
        public int Age()
        {
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString();
            string strDay = date.Substring(0, 2);
            int day = Convert.ToInt32(strDay);
            string strMonth = date.Substring(3, 2);
            int month = Convert.ToInt32(strMonth);
            string strYear = _dateOfBirth.Substring(6, 4);
            int birthYear = Convert.ToInt32(strYear);
            string strBirthMonth = _dateOfBirth.Substring(3, 2);
            int birthMonth = Convert.ToInt32(strBirthMonth);
            string strBirthDay = _dateOfBirth.Substring(0, 2);
            int birthDay = Convert.ToInt32(strBirthDay);
            if (month > birthMonth)
            {
                return 2021 - birthYear;
            }
            if (month == birthMonth)
            {
                if (day >= birthDay)
                {
                    return 2021 - birthYear;
                }
                else
                {
                    return 2020 - birthYear;
                }
            }
            return 2020 - birthYear;
        }
        public bool Valid { get { return Age() >= 0; } }
        public bool Adult { get { return Age() >= 18; } }
        public string ZodiacAnimal { get {string strYear = _dateOfBirth.Substring(6, 4);
                int year = Convert.ToInt32(strYear);
                year = year % 12;
                string[] animals = new string[] { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };
                for (int i = 0; i < animals.Length; i++)
                {
                    if (year == i)
                    {
                        return animals[i];
                    }
                }
                return null;
            }
        }
        public bool Birthday { get {
                DateTime localDate = DateTime.Now;
                string date = localDate.ToString();
                date = date.Substring(0, 5);
                return  _dateOfBirth.Substring(0, 5) == date ? true : false;
            } 
        }
        public string ScreenName { get { return $"Name : {FirstName} {LastName} \nEmail Address : {EmailAddress} \nDate Of Birth : {DateOFBirth}"; } }
        public override string ToString()
        {
            return $"Name : {FirstName} {LastName} \nEmail Address : {EmailAddress} \nDate Of Birth : {DateOFBirth}";
        }
        public Person()
        {
        }
        public virtual void Greet()
        {
            Console.WriteLine("Hello I am a person.");
        }
        public override void Describe() 
        {
            Console.WriteLine(ToString());
        }
        public override void Discipline()
        {

        }
    }
}
