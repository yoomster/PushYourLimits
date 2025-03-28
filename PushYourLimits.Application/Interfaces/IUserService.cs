using PushYourLimits.Domain;
using System.ComponentModel.DataAnnotations;

namespace PushYourLimits.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUserAccount(User user);

        Task DeleteUserAccount(int userId);

    }
}
