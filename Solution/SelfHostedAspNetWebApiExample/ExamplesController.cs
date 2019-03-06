using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostedAspNetWebApiExample
{
    public class ExamplesController : ApiController
    {
        // GET api/examples 
        public IEnumerable<string> Get()
        {
            return new string[] { "example1", "example2" };
        }

        // GET api/examples/5 
        public string Get(int id)
        {
            return $"example value for id: {id}";
        }

        // POST api/examples
        public void Post([FromBody]string value)
        {
        }

        // PUT api/examples/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/examples/5 
        public void Delete(int id)
        {
        }
    }
}