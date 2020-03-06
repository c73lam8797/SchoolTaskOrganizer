using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolTaskOrganizer.Server.TaskOrganizer.DeliverableAPI;
using SchoolTaskOrganizer.Shared.Models;

namespace SchoolTaskOrganizer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliverablesController : ControllerBase
    {
        private readonly DeliverableContext _context;

        public DeliverablesController(DeliverableContext context)
        {
            _context = context;
        }

        // GET: api/Deliverables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deliverable>>> Get_deliverable()
        {
            return await _context._deliverable.ToListAsync();
        }

        //// GET: api/Deliverables/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Deliverable>> GetDeliverable(string id)
        //{
        //    var deliverable = await _context._deliverable.FindAsync(id);

        //    if (deliverable == null)
        //    {
        //        return NotFound();
        //    }

        //    return deliverable;
        //}


        // PUT: api/Deliverables/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliverable(string id, Deliverable deliverable)
        {
            if (id != deliverable.CourseCode)
            {
                return BadRequest();
            }

            _context.Entry(deliverable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliverableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Deliverables
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Deliverable>> PostDeliverable(Deliverable deliverable)
        {
            _context._deliverable.Add(deliverable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }

            return CreatedAtAction("GetDeliverable", new { id = deliverable.CourseCode }, deliverable);
        }

        // DELETE: api/Deliverables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Deliverable>> DeleteDeliverable(string id)
        {
            var deliverable = await _context._deliverable.FindAsync(id);
            if (deliverable == null)
            {
                return NotFound();
            }

            _context._deliverable.Remove(deliverable);
            await _context.SaveChangesAsync();

            return deliverable;
        }

        private bool DeliverableExists(string id)
        {
            return _context._deliverable.Any(e => e.CourseCode == id);
        }
    }
}
