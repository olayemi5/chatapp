using DarkerPlight.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence.Interface
{
    public interface IChatRepository
    {
        Task<bool> Add(Chat userChats);
        Task<bool> AddGroupChat(Chat userChats);
        Task<List<Chat>> Get();
        Task<List<string>> GetMutuals(string userId);
        List<Chat> Get(string userIdOne, string userIdTwo);
    }
}
