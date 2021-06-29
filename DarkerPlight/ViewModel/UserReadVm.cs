using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.ViewModel
{
    public class UserReadVm
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }
        public bool IsActive { get; set; }
        public byte[] UserImage { get; set; }
    }
}
