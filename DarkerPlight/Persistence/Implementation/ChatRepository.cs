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
        private readonly AppDbContext context;
        public ChatRepository(AppDbContext context)
        {
            this.context = context;
        }
        public bool Add(Chat userChats)
        {
            context.Chat.Add(userChats);
            return context.SaveChanges() > 0 ? true : false;
        }

        public Task<bool> AddGroupChat(Chat userChats)
        {
            throw new NotImplementedException();
        }

        public Task<List<Chat>> Get()
        {
            throw new NotImplementedException();
        }

        public List<Chat> Get(string userIdOne, string userIdTwo)
        {
            return context.Chat.Where(e => e.UserIdOne == userIdOne && e.UserIdTwo == userIdTwo || e.UserIdTwo == userIdOne && e.UserIdOne == userIdTwo).OrderBy(e => e.ChatTime).ToList();
        }

        public List<Chat> GetGroupMessage(int groupNumber)
        {
            return context.Chat.Where(e => e.GroupNumber == groupNumber).OrderBy(e => e.ChatTime).ToList();
        }

        public  List<string> GetMutuals(string userId)
        {
            var result =  context.Chat.Where(e => e.UserIdOne == userId || e.UserIdTwo == userId).Select(p => p.Recipient).Distinct().ToList();
            return result;
        }
    }
}
