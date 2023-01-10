using Newtonsoft.Json;
using static Microsoft.Maui.Controls.Internals.Profile;

namespace HeadHunter.Models.Store;

public class BundleDataMetadata
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("data")]
    public List<BundleData> Data { get; set; }
}
