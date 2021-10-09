using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackatonVtb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private RoleManager<IdentityRole> _roleManager { get; set; }
        private UserManager<User> _userManager { get; set; }

        [HttpGet("id")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            var roles = await _userManager.GetRolesAsync(user);

            return Ok(roles);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
            {
                throw new InvalidOperationException("No user");
            }

            var role = await _roleManager.FindByNameAsync(roleName);

            if (role is null)
            {
                throw new InvalidOperationException("Role not found");
            }

            var result = _userManager.AddToRoleAsync(user, role.Name);

            return Ok(result.IsCompletedSuccessfully);
        }
    }
}
