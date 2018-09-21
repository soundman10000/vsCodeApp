/*
This is a block comment
 */

using System;

namespace Application.N.Shit
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime birthdate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;

        }

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime Birthdate { get; }
    }
}