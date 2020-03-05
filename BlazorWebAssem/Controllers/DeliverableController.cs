using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using BlazorWebAssem.TaskOrganizer.Deliverable;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWebAssem.Controllers
{
    [Route("api/[controller]")]
    public class DeliverableController : ControllerBase
    {

        private DeliverableOperations dbops = new DeliverableOperations();

        [HttpGet]
        [Route("api/Deliverable/get")]
        public IEnumerable<Deliverable> GetDeliverables()
        {
            return dbops.GetAllDeliverables();
        }

        //// GET: api/<controller>
        //[HttpGet]  
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        [HttpPost]
        [Route("api/Deliverable/add")]
        public void Post([FromBody]Deliverable deliverable)
        {
            if (ModelState.IsValid)
            {
                dbops.AddDeliverable(deliverable);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Route("api/Deliverable/edit")]
        public void Put(int id, [FromBody]Deliverable deliverable)
        {
            if (ModelState.IsValid)
            {
                dbops.UpdateDeliverable(deliverable);
            }
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Route("api/Deliverable/delete")]
        public void Delete(Deliverable deliverable)
        {
            dbops.DeleteDeliverable(deliverable);
        }
    }
}
