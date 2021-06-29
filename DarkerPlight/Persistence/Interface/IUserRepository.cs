using DarkerPlight.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence.Interface
{
    public interface IUserRepository
    {
        Task<bool> Add(User userDetails);
        Task<string> Authenticate(string username, string password);
        Task<User> Get(string userId);
        Task<List<User>> Get();
        Task<bool> Delete(string UserId);
        Task<bool> Update(User userDetails);
    }
}
