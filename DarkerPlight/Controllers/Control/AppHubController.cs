using DarkerPlight.DataModels;
using DarkerPlight.Persistence.Interface;
using DarkerPlight.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Controllers.Control
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppHubController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IChatRepository chatRepository;
        public AppHubController(IChatRepository chatRepository, IUserRepository userRepository)
        {
            this.chatRepository = chatRepository;
            this.userRepository = userRepository;
        }

        [HttpGet("details/{username}")]
        public async Task<IActionResult> GetDetails([FromRoute] string username)
        {
            var details = await userRepository.Get(username);
            CredentialsVm.Username = details.Username;
            var response = new UserReadVm() 
            {
                UserId = details.UserId,
                Username = details.Username,
                Password = details.Password,
                IsActive =details.IsActive,
                LastLogin = details.LastLogin.ToShortTimeString(),
                UserImage = details.UserImage
            };
            return Ok(response);
        }
        
        [HttpPost("sendmessage")]
        public IActionResult SendMessage(Chat chatDetails)
        {
            return Ok();
        }


        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UserLoginVm authenticationDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bad Request");
            }

            var result = await userRepository.Authenticate(authenticationDetails.Username,authenticationDetails.Password);
            if (result == null)
            {
                var details = new User()
                {
                    Username = authenticationDetails.Username,
                    Password = authenticationDetails.Password,
                    IsActive = true,
                    LastLogin = DateTime.Now,
                    RegisteredDate = DateTime.Now,
                };
                await userRepository.Add(details);
                return Ok(details.Username);
            }
            else
            {
                return Ok(result);
            }

            return Ok(result);
        }

    }
}
