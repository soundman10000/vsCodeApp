using System.Collections;
using ServiceStack;
using System.Threading.Tasks;
using vsCode.DTO;

namespace vsCode.Requests
{
    public class PersonHandler : Service
    {
        public Task<Person> Get(GetPeopleById req)
        {
            return Task.FromResult(new Person());
        }
    }
}