using System.Collections;
using ServiceStack;
using System.Threading.Tasks;
using vsCode.Model;
using System;
using static vsCode.Model.PersonExtensions;

namespace vsCode.Requests
{
    public class PersonHandler : Service
    {
        public Task<DTO.Person> Get(GetPeopleById req)
        {

            var name = new Model.Name("Jason", "Malley", "Scott", null, null);
            var person = new Model.Person(name, new DateTime(1982, 11, 10), Gender.Male);

            return Task.FromResult(ToPersonDTO(person));
        }
    }
}