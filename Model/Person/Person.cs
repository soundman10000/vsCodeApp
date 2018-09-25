/*
This is a block comment
 */

using System;

namespace vsCode.Model
{
    public struct Person
    {
        public Name Name { get; }
        public Gender Gender { get; }
        public DateTime Birthdate { get; }

        public Person(Name name, DateTime birthdate, Gender gender)
        {
            this.Gender = gender;
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}