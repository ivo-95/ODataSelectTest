using ODataSelectTest.Models;
using ODataSelectTest.Services;
using System.Linq;
using System.Web.Http;
using System.Web.OData;

namespace ODataSelectTest.Controllers
{
    public class PeopleController : ODataController
    {
        [HttpGet]
        [CustomQuery]
        public IQueryable<Person> Get(string gender)
        {
            var service = new PeopleService();
            var result = service.GetPeople(gender);

            return result;
        }

        [HttpGet]
        [CustomQuery]
        public SingleResult<Person> Get([FromODataUri] int key, string gender)
        {
            var service = new PeopleService();
            var result = service.GetPerson(key, gender);

            return SingleResult.Create(result);
        }
    }
}
