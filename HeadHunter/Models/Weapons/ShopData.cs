using Newtonsoft.Json;

namespace HeadHunter.Models.Weapons;

public class ShopData
{
    [JsonProperty("cost")]
    public int Cost { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("categoryText")]
    public string CategoryText { get; set; }

    [JsonProperty("gridPosition")]
    public GridPosition GridPosition { get; set; }

    [JsonProperty("canBeTrashed")]
    public bool CanBeTrashed { get; set; }

    [JsonProperty("image")]
    public object Image { get; set; }

    [JsonProperty("newImage")]
    public string NewImage { get; set; }

    [JsonProperty("newImage2")]
    public object NewImage2 { get; set; }

    [JsonProperty("assetPath")]
    public string AssetPath { get; set; }
}
