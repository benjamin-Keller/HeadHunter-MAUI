using Blazored.SessionStorage;
using HeadHunter.Models.Auth;
using HeadHunter.Models.Store;
using RiotCloudflareAuthFix;
using System.Net;
using System.Net.Http.Json;

namespace HeadHunter.Data;

public class StoreService
{
    private readonly HttpClient _client;
    private readonly ISessionStorageService _sessionStorage;
    private UserInfo _userInfo;

    public StoreService(HttpClient client, ISessionStorageService sessionStorage)
    {
        _client = client;
        _client.DefaultRequestHeaders.Add("X-Curl-Source", "Api");
        _sessionStorage = sessionStorage;
    }

    public async Task<FeaturedStore> GetFeaturedStoreAsync(UserInfo user)
    {
        var accessToken = await _sessionStorage.GetItemAsync<string>("access_token");
        var entitlement = await _sessionStorage.GetItemAsync<string>("entitlement_token");
        var region = await _sessionStorage.GetItemAsync<string>("region");

        var url = new Uri($"https://pd.{region}.a.pvp.net/store/v2/storefront/{user.Sub}");

        _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
        _client.DefaultRequestHeaders.Add("X-Riot-Entitlements-JWT", $"{entitlement}");
        return await _client.GetFromJsonAsync<FeaturedStore>(url);
    }
}
