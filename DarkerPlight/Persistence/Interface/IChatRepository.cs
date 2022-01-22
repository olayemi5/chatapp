using DarkerPlight.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence.Interface
{
    public interface IChatRepository
    {
        bool Add(Chat userChats);
        Task<bool> AddGroupChat(Chat userChats);
        Task<List<Chat>> Get();
        List<string> GetMutuals(string userId);
        List<Chat> Get(string userIdOne, string userIdTwo);
        List<Chat> GetGroupMessage(int groupNumber);
    }
}
