using PushYourLimits.Application.Interfaces;
using PushYourLimits.Domain;
using System.ComponentModel.DataAnnotations;

namespace PushYourLimits.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUserAccount(User user)
        {

            User newUser = new(
                email: user.Email,
                password: user.Password,
                name: user.Name,
                birthYear: user.BirthYear
                ); 

            await _userRepository.CreateUserAsync(newUser);
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task DeleteUserAccount(int userId)
        {
            await _userRepository.DeleteByIdAsync(userId);
        }
    }
}
