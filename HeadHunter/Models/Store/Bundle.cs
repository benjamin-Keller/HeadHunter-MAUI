using Newtonsoft.Json;

namespace HeadHunter.Models.Store;

public class Bundle
{
    [JsonProperty("ID")]
    public string ID { get; set; }

    [JsonProperty("DataAssetID")]
    public string DataAssetID { get; set; }

    public List<string> BundleDisplay { get; set; }

    [JsonProperty("CurrencyID")]
    public string CurrencyID { get; set; }

    [JsonProperty("Items")]
    public List<ItemData> Items { get; set; }

    [JsonProperty("DurationRemainingInSeconds")]
    public int DurationRemainingInSeconds { get; set; }

    [JsonProperty("WholesaleOnly")]
    public bool WholesaleOnly { get; set; }
}