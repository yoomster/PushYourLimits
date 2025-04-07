using PushYourLimits.Domain;
using System.ComponentModel.DataAnnotations;

namespace PushYourLimits.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUserAccount(User user);
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetById(int id);
        Task<User> GetByEmail(string email);
        Task DeleteUserAccount(int userId);
    }
}
