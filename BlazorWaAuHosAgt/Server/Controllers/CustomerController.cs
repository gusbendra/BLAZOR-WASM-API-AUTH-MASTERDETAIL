using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorWaAuHosAgt.Shared;
using BlazorWaAuHosAgt.Shared.Modeltes;
using BlazorWaAuHosAgt.Server.Datates;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace BlazorWaAuHosAgt.Server.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
            private readonly TesDbContext context;

            public CustomerController(TesDbContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Customer>>> Get()
            {
                return await context.Customer.ToListAsync();
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Customer>> Get(int id)
            {
                var cust = await context.Customer
                    .Include(x => x.Alamat)
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (cust == null) { return NotFound(); }

                return cust;
            }

            [HttpPost]
            public async Task<ActionResult<int>> Post(Customer cust)
            {
                context.Customer.Add(cust);
                await context.SaveChangesAsync();
                return cust.Id;
            }

            [HttpPut]
            public async Task<ActionResult> Put(Customer cust)
            {
                context.Entry(cust).State = EntityState.Modified;

                foreach (var almt in cust.Alamat)
                {
                    if (almt.Id != 0)
                    {
                        context.Entry(almt).State = EntityState.Modified;
                    }
                    else
                    {
                        context.Entry(almt).State = EntityState.Added;
                    }
                }

                var idsOfAddresses = cust.Alamat.Select(x => x.Id).ToList();
                var addressesToDelete = await context
                    .Custalamat
                    .Where(x => !idsOfAddresses.Contains(x.Id) && x.CustomerId == cust.Id)
                    .ToListAsync();

                context.RemoveRange(addressesToDelete);

                await context.SaveChangesAsync();

                return NoContent();
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(int id)
            {
                var cust = new Customer { Id = id };
                context.Remove(cust);
                await context.SaveChangesAsync();
                return NoContent();
            }
        }
    }








