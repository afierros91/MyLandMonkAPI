using System;
using Entities.Models;
using System.Collections.Generic;
 
namespace Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        User GetUserByUsername(string username);
        User GetUserById(int UserId);
        void CreateUser( User user);
        void UpdateUser(User dbUser, User user);
        void DeleteUser(User user);
    }
}