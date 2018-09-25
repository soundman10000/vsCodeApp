using vsCode.DTO;

namespace vsCode.Model
{
    public static class PersonExtensions
    {
        public static DTO.Name ToNameDTO(Name name) =>
            new DTO.Name
            {
                FirstName = name.FirstName,
                LastName = name.LastName,
                MiddleName = name.MiddleName,
                Salutation = name.Salutation,
                Suffix = name.Suffix
            };

        public static DTO.Person ToPersonDTO(Person person) =>
            new DTO.Person()
            {
                Name = ToNameDTO(person.Name),
                Birthdate = person.Birthdate,
                Gender = person.Gender,
            };
    }
}