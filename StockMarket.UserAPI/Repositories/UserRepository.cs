using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.UserAPI.DBAccess;
using StockMarket.UserAPI.Models;

namespace StockMarket.UserAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserDBContext context;
        public UserRepository(UserDBContext context)
        {
            this.context = context;
        }
    }
}
