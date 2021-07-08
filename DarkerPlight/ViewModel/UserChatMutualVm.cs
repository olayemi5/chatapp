using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.ViewModel
{
    public class UserChatMutualVm
    {
        public string Username { get; set; }
        public string LastLogin { get; set; }
        public string Image { get; set; }
        public bool IsLoaded { get; set; }
    }
}
