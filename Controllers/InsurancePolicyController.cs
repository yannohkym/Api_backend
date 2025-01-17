using InsurancePolicies.Data;
using InsurancePolicies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsurancePolicies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancePolicyController : Controller
    {
       
            private readonly AppDbContext _context;

            public InsurancePolicyController(AppDbContext context)
            {
                _context = context;
            }

            // Step 5: Implement CRUD Endpoints

            // GET: api/InsurancePolicies
            [HttpGet]
            public async Task<ActionResult<IEnumerable<InsurancePolicy>>> GetInsurancePolicies()
            {
                return await _context.Policies.ToListAsync();
            }

            // GET: api/InsurancePolicies/5
            [HttpGet("{id}")]
            public async Task<ActionResult<InsurancePolicy>> GetInsurancePolicy(int id)
            {
                var policy = await _context.Policies.FindAsync(id);

                if (policy == null)
                {
                    return NotFound();
                }

                return policy;
            }

            // POST: api/InsurancePolicies
            [HttpPost]
            public async Task<ActionResult<InsurancePolicy>> CreateInsurancePolicy(InsurancePolicy policy)
            {
                if (policy == null)
                {
                    return BadRequest("Invalid policy data.");
                }

                _context.Policies.Add(policy);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetInsurancePolicy), new { id = policy.Id }, policy);
            }

            // PUT: api/InsurancePolicies/5
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateInsurancePolicy(int id, InsurancePolicy policy)
            {
                if (id != policy.Id)
                {
                    return BadRequest("Policy ID mismatch.");
                }

                _context.Entry(policy).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Policies.Any(e => e.Id == id))
                    {
                        return NotFound();
                    }
                    throw;
                }

                return NoContent();
            }

            // DELETE: api/InsurancePolicies/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteInsurancePolicy(int id)
            {
                var policy = await _context.Policies.FindAsync(id);
                if (policy == null)
                {
                    return NotFound();
                }

                _context.Policies.Remove(policy);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
} 
