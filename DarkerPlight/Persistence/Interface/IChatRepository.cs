using DarkerPlight.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkerPlight.Persistence.Interface
{
    public interface IChatRepository
    {
        Task<bool> Add(IChatRepository userChats);
        Task<Chat> Get();
    }
}
