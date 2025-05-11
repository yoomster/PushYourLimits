using PushYourLimits.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushYourLimits.Application.Interfaces
{
    public  interface IUserRepository
    {
        Task CreateUserAsync(User user);

        Task<User?> GetByEmailAsync(string email);

        Task<User?> GetByIdAsync(int id);

        Task<IEnumerable<User>> GetAllAsync();

        Task<bool> UpdateAccountAsync(User user);

        Task<bool> DeleteByIdAsync(int userId);

        Task<bool> IsEmailDuplicate(string email);
    }
}