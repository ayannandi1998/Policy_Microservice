using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Policy_Microservice.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Policy_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        readonly log4net.ILog _log4net;
        IPolicyrep db;
        public PolicyController(IPolicyrep _db)
        {
            db = _db;
            _log4net = log4net.LogManager.GetLogger(typeof(PolicyController));
        }
        // GET: api/<PolicyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PolicyController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
          _log4net.Info("PolicyController get chain of providers");
          try
          {
                List<string> chain = db.GetChainProvider(id);
                if (chain.Count == 0)
                    return NotFound();
                return Ok(chain);
          }
          catch(Exception)
          {
                return BadRequest();
          }
        }
        [HttpGet("{mid}/{pid}")]
        public IActionResult Get1(string mid,string pid)
        {
            _log4net.Info("PolicyController get eligible benefits");
            try
            {
                List<int> chain = db.GetEligibleBenefits(mid,pid);
                if (chain.Count == 0)
                    return NotFound();
                return Ok(chain);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // POST api/<PolicyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PolicyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PolicyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
