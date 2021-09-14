using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Object.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenGlass_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountsController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, false, false);

                if (result.Succeeded)
                {
                    return Ok(loginDto);
                }
                return BadRequest(new { Error = "Invalid Login Attempt" });
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsync(RegisterDto model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PasswordHash = model.Password
                };
                try
                {
                    IdentityUser identityUser = null;
                
                // check duplication
                    identityUser = await _userManager.FindByEmailAsync(model.Email);
                
                if (identityUser is null)
                {
                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        return Ok(model);
                    }
                }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                return BadRequest(new { Error = "User is already register" });
            }
            return BadRequest();
        }
    }
}
