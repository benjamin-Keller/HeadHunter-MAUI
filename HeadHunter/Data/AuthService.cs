using Blazored.SessionStorage;
using HeadHunter.Data.Handlers;
using HeadHunter.Models.Auth;

namespace HeadHunter.Data;

public class AuthService
{
    private readonly AuthHandler _authHandler;
    private readonly ISessionStorageService _sessionStorage;

    public AuthService(AuthHandler authHandler, ISessionStorageService sessionStorage)
    {
        _authHandler = authHandler;
        _sessionStorage = sessionStorage;
    }

    public async Task<UserInfo> AuthenticateAsync(RiotUser user)
    {
        var (loginResponse, cookieCollection, accessToken) = await _authHandler.HandleAuthAsync(user);
        var entitlementToken = await _authHandler.GetEntitlementAsync(accessToken, cookieCollection);

        var userInfo = new UserInfo();
        userInfo = await _authHandler.GetUserInfo();
        userInfo.Entitlement = entitlementToken;

        await _sessionStorage.SetItemAsync("access_token", accessToken);
        await _sessionStorage.SetItemAsync("entitlement_token", entitlementToken.EntitlementsToken);
        await _sessionStorage.SetItemAsync("region", userInfo.Affinity?.Region);

        return userInfo;
    }
}
