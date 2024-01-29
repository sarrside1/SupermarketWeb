using Microsoft.AspNetCore.Components.Authorization;
using SupermarketWeb.Data.Dtos;
using System.Security.Claims;

namespace SupermarketWeb.Data.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal userClaim;

        public async Task LoginAsync(TokenResponse token, User user)
        {
            // Simulate a login process
            var identity = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.Name, user.username),
            new Claim(ClaimTypes.Email, ""),
            new Claim("StoreId", user.storeId.ToString()),
            new Claim("LoggedUser", user.username),
            new Claim("LoggedUserLevel", token.LoggedUserLevel.ToString()),
            new Claim("LoggedUserId", user.id.ToString()),
            new Claim("StoreType", token.StoreType.ToString())
        }, "custom_authentication_type");

            userClaim = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(userClaim)));
        }

        public void Logout()
        {
            // Simulate a logout process
            userClaim = null;

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(userClaim)));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return await Task.FromResult(new AuthenticationState(userClaim));
        }
    }
}
