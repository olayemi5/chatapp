using DarkerPlight.DataModels;
using DarkerPlight.Persistence.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext  context;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> Add(User userDetails)
        {
            var users = context.Users.ToList();
            foreach (var user in users)
            {
                if (userDetails.Username.ToLower() == user.Username.ToLower())
                {
                    return false;
                }
            }
            await context.Users.AddAsync(userDetails);
            var chk = context.SaveChanges() > 0 ? true : false;
            return chk;
        }


        public async Task<string> Authenticate(string username, string password)
        {
            var details =  context.Users.Where(e => e.Username == username && e.Password == password).FirstOrDefault();
            if (details == null)
                return null;

            return details.Username;
        }

        public async Task<bool> Delete(string username)
        {
            var user =  context.Users.Where(e => e.UserId == username).FirstOrDefault();
            context.Users.Remove(user);
            return context.SaveChanges() > 0 ? true : false;
        }

        public async Task<User> Get(string username)
        {
            var user = context.Users.FirstOrDefault(e => e.Username == username);
            return user;
        }
        public async Task<List<User>> Get()
        {
            return context.Users.ToList();
        }

        

        public async Task<bool> UpdateLastSeen(string username)
        {
            var user = context.Users.FirstOrDefault(e => e.Username == username);
            if (user != null)
            {
                user.LastLogin = DateTime.Now;
            }
            context.Update(user);
            return context.SaveChanges() > 0 ? true : false;
        }

        public async Task<bool> UpdateUserImage(byte[] photo, string username)
        {
            var user = context.Users.FirstOrDefault(e => e.Username == username);
            if (user != null)
            {
                user.UserImage = photo;
            }
            context.Update(user);
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
