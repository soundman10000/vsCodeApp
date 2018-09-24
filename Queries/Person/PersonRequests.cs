using ServiceStack;
using System;

namespace vsCode.Requests
{
    [Route("/person/{Id}", "GET")]
    public class GetPeopleById : IReturn<vsCode.DTO.Person>
    {
        public Guid Id { get; set; }
    }
}