using PushYourLimits.Application.Interfaces;
using PushYourLimits.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushYourLimits.Infrastructure
{
    internal class UserRepository 
    {
        private readonly PYLDbContext _context;

        public UserRepository(PYLDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserAsync(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public Task<bool> DeleteByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        //public Task<User?> GetByEmailAsync(string email)
        //{
        //    var user = _context.Users
        //        .Where(u => u.Email == email);

        //    return user;
        //}

        public Task<User?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public Task<bool> IsEmailDuplicate(string email)
        //{
        //    var user = GetByEmailAsync(email);
        //    return user != null;
        //}

        public Task<bool> UpdateAccountAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
