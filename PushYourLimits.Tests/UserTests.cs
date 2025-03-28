using PushYourLimits.Application.Services;

namespace PushYourLimits.Tests
{
    public class UserTests
    {
        private readonly UserService _sut;

        public UserTests()
        {
            _sut = new UserService();
        }
    }
}
