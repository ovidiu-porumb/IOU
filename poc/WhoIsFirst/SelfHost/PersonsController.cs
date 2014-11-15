using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SelfHost
{
    public class PersonsController : ApiController
    {
        public IEnumerable<string> Get()
        {
            using (PersonContext context = new PersonContext())
            {
                List<Person> people = context.Persons.ToList();
                return people.Select(p => p.FirstName).ToArray();
            }
        }
    }
}