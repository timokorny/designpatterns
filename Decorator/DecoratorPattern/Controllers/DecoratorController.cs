using DecoratorPattern.Pattern;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecoratorController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{data}")]
        public ActionResult<string> Get(string data)
        {
            Component component = new Component();
            IComponent pre = new ComponentDecoratorPre(component);
            IComponent post = new ComponentDecoratorPost(pre);


            IComponent post2 = new ComponentDecoratorPost(component);
            IComponent pre2 = new ComponentDecoratorPre(post2);

            string ret = "\ncomponent -> pre -> post \n";

            ret += post.Operation(data);

            ret += "\ncomponent -> post -> pre \n";

            ret += pre2.Operation(data);
            
            return Ok(ret);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
