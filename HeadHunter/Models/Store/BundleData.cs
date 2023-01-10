using Newtonsoft.Json;

namespace HeadHunter.Models.Store;

public class BundleData
{
    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    [JsonProperty("displayName")]
    public string DisplayName { get; set; }

    [JsonProperty("displayNameSubText")]
    public object DisplayNameSubText { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("extraDescription")]
    public string ExtraDescription { get; set; }

    [JsonProperty("promoDescription")]
    public string PromoDescription { get; set; }

    [JsonProperty("useAdditionalContext")]
    public bool UseAdditionalContext { get; set; }

    [JsonProperty("displayIcon")]
    public string DisplayIcon { get; set; }

    [JsonProperty("displayIcon2")]
    public string DisplayIcon2 { get; set; }

    [JsonProperty("verticalPromoImage")]
    public string VerticalPromoImage { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }
}
