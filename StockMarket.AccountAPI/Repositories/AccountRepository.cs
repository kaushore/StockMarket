using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.DBAccess;

namespace StockMarket.AccountAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private AccountDBContext context;
        public AccountRepository(AccountDBContext context)
        {
            this.context = context;
        }
        public void AddUser(User item)
        {
            context.Add(item);
            context.SaveChanges();
        }
        public User Validate(string uname, string pwd)
        {
            User user = context.Users.SingleOrDefault(i => i.Username == uname && i.Password == pwd);
            return user;
        }
        public User EditUserDetails(User user)
        {
            User userToUpdate = context.Users.FirstOrDefault(u => u.UserId == user.UserId);
            userToUpdate.Username = user.Username;
            userToUpdate.Password = user.Password;
            userToUpdate.Mobile = user.Mobile;
            //context.Users.Update(user);
            context.SaveChanges();
            //return user;
            return userToUpdate; 
        }
    }
}
