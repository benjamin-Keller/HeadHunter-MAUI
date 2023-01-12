using Blazored.LocalStorage;
using HeadHunter.Data.Handlers;
using HeadHunter.Models.Auth;

namespace HeadHunter.Data;

public class AuthService
{
    private readonly AuthHandler _authHandler;
    private readonly ILocalStorageService _localStorage;

    public AuthService(AuthHandler authHandler, ILocalStorageService localStorage)
    {
        _authHandler = authHandler;
        _localStorage = localStorage;
    }

    public async Task<UserInfo> AuthenticateAsync(RiotUser user)
    {
        var (loginResponse, cookieCollection, accessToken) = await _authHandler.HandleAuthAsync(user);
        var entitlementToken = await _authHandler.GetEntitlementAsync(accessToken, cookieCollection);

        var userInfo = await _authHandler.GetUserInfo();
        userInfo.Entitlement = entitlementToken;

        await _localStorage.SetItemAsync("username", $"{userInfo.Acct?.GameName}#{userInfo.Acct?.TagLine}");
        await _localStorage.SetItemAsync("puuid", userInfo.Sub);
        await _localStorage.SetItemAsync("access_token", accessToken);
        await _localStorage.SetItemAsync("entitlement_token", entitlementToken.EntitlementsToken);
        await _localStorage.SetItemAsync("region", userInfo.Affinity?.Region);

        return userInfo;
    }
}
