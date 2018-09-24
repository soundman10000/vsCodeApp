//This fils contains the person dto response.

using System;

namespace vsCode.DTO
{

    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public class Person
    {
        public Name Name { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
    }
}