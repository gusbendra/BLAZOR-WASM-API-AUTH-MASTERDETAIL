using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWaAuHosAgt.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserroleController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterModel model)
        {
            var newUser = new IdentityUser { UserName = model.Email, Email = model.Email };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return BadRequest(new RegisterResult { Successful = false, Errors = errors });
            }

            // Add all new users to the User role
            await _userManager.AddToRoleAsync(newUser, "User");

            // Add new users whose email starts with 'admin' to the Admin role
            if (newUser.Email.StartsWith("admin"))
            {
                await _userManager.AddToRoleAsync(newUser, "Admin");
            }

            return Ok(new RegisterResult { Successful = true });
        }

    }


}
