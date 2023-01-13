using Blazored.LocalStorage;
using HeadHunter.Models.Pregame;
using HeadHunter.Resources;
using System.Net.Http.Json;

namespace HeadHunter.Data
{
    public class PregameService
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;

        public PregameService(HttpClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _client.DefaultRequestHeaders.Add("X-Curl-Source", "Api");
            _localStorage = localStorage;
        }

        public async Task<SessionMetadata> GetPlayerSessionAsync(string puuid)
        {
            var accessToken = await _localStorage.GetItemAsync<string>("access_token");
            var entitlement = await _localStorage.GetItemAsync<string>("entitlement_token");
            var region = await _localStorage.GetItemAsync<string>("region");

            var url = new Uri($"https://glz-{region}-1.{region}.a.pvp.net/pregame/v1/players/{puuid}");
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
            _client.DefaultRequestHeaders.Add("X-Riot-Entitlements-JWT", $"{entitlement}");
            return await _client.GetFromJsonAsync<SessionMetadata>(url);
        }

        public async Task<Match> GetMatchAsync(string uuid)
        {
            var accessToken = await _localStorage.GetItemAsync<string>("access_token");
            var entitlement = await _localStorage.GetItemAsync<string>("entitlement_token");
            var region = await _localStorage.GetItemAsync<string>("region");

            var url = new Uri($"https://glz-{region}-1.{region}.a.pvp.net/pregame/v1/matches/{uuid}");
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
            _client.DefaultRequestHeaders.Add("X-Riot-Entitlements-JWT", $"{entitlement}");
            return await _client.GetFromJsonAsync<Match>(url);
        }
    }
}
