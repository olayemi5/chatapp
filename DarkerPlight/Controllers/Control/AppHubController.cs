using DarkerPlight.DataModels;
using DarkerPlight.Persistence.Interface;
using DarkerPlight.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
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

        [HttpPut("updateLastSeen")]
        public async Task<IActionResult> UpdateLastLogin(string username, string connectionId)
        {
            await userRepository.UpdateLastSeen(username, connectionId);
            return Ok();
        }
        
        [HttpPost("saveuserphoto")]
        public async Task<IActionResult> SaveUserPhoto(UserPhotoUpdateVm model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Model state");
            }

            string cleandata = model.Base64ImageData.Replace("data:image/jpeg;base64,", string.Empty);
            byte[] photo = Convert.FromBase64String(cleandata);

            bool result;

            result = await userRepository.UpdateUserImage(photo,model.Username);

            return Ok(result);
        }
        
        [HttpGet("getMutal/{username}")]
        public async Task<IActionResult> GetMutaulFriends([FromRoute] string username)
        {
            var details = chatRepository.GetMutuals(username);
            var result = new List<UserChatMutualVm>();
            foreach (var user in details)
            {
                if (user != username)
                {
                    var getLastLoggedIn = await userRepository.Get(user);
                    var mutalDetails = new UserChatMutualVm()
                    {
                        Username = user,
                        LastLogin = getLastLoggedIn.LastLogin.ToShortDateString(),
                        Image =  "https://static.turbosquid.com/Preview/001214/650/2V/boy-cartoon-3D-model_D.jpg",
                        IsLoaded = false,
                        Online = false,
                        Connection = getLastLoggedIn.LastConnectionId
                    };
                    result.Add(mutalDetails);
                }
            }
            return Ok(result);
        }
        
        [HttpPost("sendmessage")]
        public IActionResult SendMessage(Chat chatDetails)
        {
            if (ModelState.IsValid)
            {
                chatDetails.ChatTime = DateTime.Now;
                var result = chatRepository.Add(chatDetails);
                if (result)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else
                return BadRequest();

        }

        [HttpGet("getmessage")]
        public IActionResult GetMessage(string userIdOne, string userIdTwo)
        {
            var response =  chatRepository.Get(userIdOne, userIdTwo);
            var message = new  List<ChatVm>();
            foreach (var item in response)
            {
                var result = new ChatVm() 
                {
                   Message = item.Message,
                   Recipient = item.Recipient,
                   UserIdOne = item.UserIdOne,
                   UserIdTwo = item.UserIdTwo,
                   ChatTime = item.ChatTime.ToString("MMMM dd hh:mm tt"),
                   ChatId = item.ChatId
                 };

                message.Add(result);
            }
            return Ok(message);
        }
        
        [HttpGet("getgroupmessage")]
        public IActionResult GetGroupMessage(int groupNumber)
        {
            var response = chatRepository.GetGroupMessage(groupNumber);
            var message = new List<ChatVm>();
            foreach (var item in response)
            {
                var result = new ChatVm()
                {
                    Message = item.Message,
                    Recipient = item.Recipient,
                    UserIdOne = item.UserIdOne,
                    UserIdTwo = item.UserIdTwo,
                    ChatTime = item.ChatTime.ToString("MMMM dd hh:mm tt"),
                    ChatId = item.ChatId
                };

                message.Add(result);
            }
            return Ok(message);
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
               
                var chk = await userRepository.Add(details);
                if (chk)
                {
                    CredentialsVm.Username = authenticationDetails.Username;
                    HttpContext.Session.SetString("SessionName", authenticationDetails.Username);

                    return Ok(details.Username);
                }
                else
                {
                    return BadRequest("Choose another Username");
                }
            }
            else
            {
                CredentialsVm.Username = authenticationDetails.Username;
                HttpContext.Session.SetString("SessionName", authenticationDetails.Username);
                return Ok(result);
            }
        }

    }
}
