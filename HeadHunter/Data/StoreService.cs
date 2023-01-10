using Blazored.SessionStorage;
using HeadHunter.Models.Auth;
using HeadHunter.Models.Store;
using HeadHunter.Models.Weapons;
using RiotCloudflareAuthFix;
using System.Net;
using System.Net.Http.Json;

namespace HeadHunter.Data;

public class StoreService
{
    private readonly HttpClient _client;
    private readonly WeaponsService _weaponsService;
    private readonly ISessionStorageService _sessionStorage;
    private UserInfo _userInfo;
    private IEnumerable<WeaponMetadata> _weaponCache { get; set; }

    public StoreService(HttpClient client, WeaponsService weaponsService, ISessionStorageService sessionStorage)
    {
        _client = client;
        _client.DefaultRequestHeaders.Add("X-Curl-Source", "Api");
        _weaponsService = weaponsService;
        _sessionStorage = sessionStorage;
    }

    public async Task<Store> GetFeaturedStoreAsync(UserInfo user)
    {
        var accessToken = await _sessionStorage.GetItemAsync<string>("access_token");
        var entitlement = await _sessionStorage.GetItemAsync<string>("entitlement_token");
        var region = await _sessionStorage.GetItemAsync<string>("region");

        var url = new Uri($"https://pd.{region}.a.pvp.net/store/v2/storefront/{user.Sub}");

        _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
        _client.DefaultRequestHeaders.Add("X-Riot-Entitlements-JWT", $"{entitlement}");
        return await _client.GetFromJsonAsync<Store>(url);
    }

    public async Task<IEnumerable<BundleData>> GetBundleDataAsync()
    {
        var _bundleData = await _client.GetFromJsonAsync<BundleDataMetadata>("https://valorant-api.com/v1/bundles");

        return _bundleData.Data;
    }

    public async Task<(IEnumerable<string> FeaturedBundles, IEnumerable<Level> StoreItems)> GetStoreItemsAsync(UserInfo user)
    {
        var _store = await GetFeaturedStoreAsync(user);
        var _skins = await _weaponsService.GetWeaponSkinByUuidAsync(_store.SkinsPanelLayout?.SingleItemOffers);
        var _bundles = _store.FeaturedBundle?.Bundles;
        var _bundleData = await GetBundleDataAsync();
        var bundles = new List<string>();

        foreach (var bundle in _bundles)
        {
            bundles.Add(_bundleData.FirstOrDefault(e => e.Uuid == bundle.DataAssetID).DisplayIcon);
        }

        return (bundles, _skins);
    }
}
