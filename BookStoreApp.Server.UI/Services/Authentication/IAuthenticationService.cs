using BookStoreApp.Server.UI.Services.Base;

namespace BookStoreApp.Server.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);

        public Task Logout();
    }
}
