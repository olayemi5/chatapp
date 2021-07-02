using DarkerPlight.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Controllers
{
    public class ChatRoomController : Controller
    {
        public IActionResult Chat(string username)
        {
            if (HttpContext.Session.GetString("SessionName") == null)
            {
                return View("ChatDashboard");
            }
            ViewBag.Username = username;
            return View();
        }
        
        public IActionResult ChatDashboard()
        {
            return View();
        }
    }
}
