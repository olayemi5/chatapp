using DarkerPlight.DataModels;
using DarkerPlight.Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence.Implementation
{
    public class ChatRepository : IChatRepository
    {
        public Task<bool> Add(IChatRepository userChats)
        {
            throw new NotImplementedException();
        }

        public Task<Chat> Get()
        {
            throw new NotImplementedException();
        }
    }
}
