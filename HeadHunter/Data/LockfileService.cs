using RiotCloudflareAuthFix;

namespace HeadHunter.Data;

public class LockfileService
{
    private readonly HttpClient _http;
    private readonly AuthenticationJsonClient _client;

    public LockfileService(HttpClient http)
	{
        _http = http;
    }

    public async Task GetEntitlement()
    {

    }
}
