using System;
using Newtonsoft.Json;

namespace vsCode.Model
{
    public struct Name
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public string Salutation { get; }
        public string Suffix { get; }

        public Name(
            string firstName, 
            string lastName, 
            string middleName, 
            string salutation, 
            string suffix)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Salutation = salutation;
            this.Suffix = suffix;
        }
    }
}