using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubscriptionMicroservice.DAL;
using SubscriptionMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubscriptionMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        // GET: api/<SubscriptionController>
        [HttpGet]
        public IEnumerable<SubscriptionDetails> Get()
        {
            SubscriptionRepository sr = new SubscriptionRepository();
            return sr.ViewSubscriptions();
        }

        // GET api/<SubscriptionController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            SubscriptionRepository sr = new SubscriptionRepository();
            SubscriptionDetails subscription = sr.GetSubscriptionByID(id);
            if (subscription != null)
            {
                return StatusCode(StatusCodes.Status200OK, subscription);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<SubscriptionController>
        [HttpPost]
        public IActionResult Post(SubscriptionDetails subscription)
        {
            SubscriptionRepository sr = new SubscriptionRepository();
            string status = sr.AddSubscription(subscription);
            return Ok(status);
        }

        // PUT api/<SubscriptionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubscriptionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            SubscriptionRepository sr = new SubscriptionRepository();
            //try 
            //{
            //    string status = sr.RemoveSubscription(id);
            //    return Ok(status);
            //}
            //catch(Exception)
            //{
            //    return BadRequest();
            //}
            string status = sr.RemoveSubscription(id);
            return Ok(status);
        }
    }
}
