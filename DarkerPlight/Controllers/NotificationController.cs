using DarkerPlight.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Controllers
{
    public class PushNotificationController : Controller
    {
        private  IHubContext<PushNotificationHub> hubcontext;
        public PushNotificationController(IHubContext<PushNotificationHub> hubcontext)
        {
            this.hubcontext = hubcontext;
        }

       [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

     
        public async Task<IActionResult> Post(string message) 
        {
            await hubcontext.Clients.All.SendAsync("RecieveMessage", message);
            return RedirectToAction("Index");
        }
    }
}
