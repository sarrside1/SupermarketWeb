using Microsoft.JSInterop;

namespace SupermarketWeb.Data.Services
{
    public class CookieService
    {
        private readonly IJSRuntime _jsRuntime;

    public CookieService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime ?? throw new ArgumentNullException(nameof(jsRuntime));
    }

    public async Task StartSession(string SessionKey, string sessionValue, int durationMinutes)
    {
        //string sessionId = Guid.NewGuid().ToString();
        DateTime expireTime = DateTime.UtcNow.AddMinutes(durationMinutes);
    
        // Use JSRuntime to invoke JavaScript to set the cookie
        await _jsRuntime.InvokeVoidAsync("setCookie", SessionKey, sessionValue, expireTime.ToString("O"));
    }

    public async Task<object> GetSessionId(string SessionKey)
    {
        // Use JSRuntime to invoke JavaScript to get the cookie
        return await _jsRuntime.InvokeAsync<object>("getCookie", SessionKey);
    }

    public async Task EndSession(string SessionKey)
    {
        // Use JSRuntime to invoke JavaScript to remove the cookie
        await _jsRuntime.InvokeVoidAsync("removeCookie", SessionKey);
    }


    public async Task SetAccessTokenCookie(string token)
    {
        // Set the access token in a cookie with a timer
        await _jsRuntime.InvokeVoidAsync("setCookie", "accessToken", token, 60 * 10); // 10 minutes
    }

    public async Task SetRefreshTokenCookie(string token)
    {
        // Set the refresh token in a cookie with a timer
        await _jsRuntime.InvokeVoidAsync("setCookie", "refreshToken", token, 60 * 10); // 10 days
    }

    public async Task<string> GetCookie(string cookieName)
    {
        return await _jsRuntime.InvokeAsync<string>("getCookie", cookieName);
    }

    }
}