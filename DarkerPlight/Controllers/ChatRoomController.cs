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
            ViewBag.Username = username;
            return View();
        }
        
        public IActionResult ChatDashboard()
        {
            return View();
        }
    }
}
