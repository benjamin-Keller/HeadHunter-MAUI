using Newtonsoft.Json;

namespace HeadHunter.Models.Store;

public class FeaturedStore
{
    [JsonProperty("FeaturedBundle")]
    public FeaturedBundle FeaturedBundle { get; set; }

    [JsonProperty("SkinsPanelLayout")]
    public SkinsPanelLayout SkinsPanelLayout { get; set; }
}

public class Bundle
{
    [JsonProperty("ID")]
    public string ID { get; set; }

    [JsonProperty("DataAssetID")]
    public string DataAssetID { get; set; }

    [JsonProperty("CurrencyID")]
    public string CurrencyID { get; set; }

    [JsonProperty("Items")]
    public List<ItemData> Items { get; set; }

    [JsonProperty("DurationRemainingInSeconds")]
    public int DurationRemainingInSeconds { get; set; }

    [JsonProperty("WholesaleOnly")]
    public bool WholesaleOnly { get; set; }
}

public class Bundle2
{
    [JsonProperty("ID")]
    public string ID { get; set; }

    [JsonProperty("DataAssetID")]
    public string DataAssetID { get; set; }

    [JsonProperty("CurrencyID")]
    public string CurrencyID { get; set; }

    [JsonProperty("Items")]
    public List<ItemData> Items { get; set; }

    [JsonProperty("DurationRemainingInSeconds")]
    public int DurationRemainingInSeconds { get; set; }

    [JsonProperty("WholesaleOnly")]
    public bool WholesaleOnly { get; set; }
}

public class FeaturedBundle
{
    [JsonProperty("Bundle")]
    public Bundle Bundle { get; set; }

    [JsonProperty("Bundles")]
    public List<Bundle> Bundles { get; set; }

    [JsonProperty("BundleRemainingDurationInSeconds")]
    public int BundleRemainingDurationInSeconds { get; set; }
}

public class ItemData
{
    [JsonProperty("Item")]
    public ItemData Item { get; set; }

    [JsonProperty("BasePrice")]
    public int BasePrice { get; set; }

    [JsonProperty("CurrencyID")]
    public string CurrencyID { get; set; }

    [JsonProperty("DiscountPercent")]
    public int DiscountPercent { get; set; }

    [JsonProperty("DiscountedPrice")]
    public int DiscountedPrice { get; set; }

    [JsonProperty("IsPromoItem")]
    public bool IsPromoItem { get; set; }
}

public class Item2
{
    [JsonProperty("ItemTypeID")]
    public string ItemTypeID { get; set; }

    [JsonProperty("ItemID")]
    public string ItemID { get; set; }

    [JsonProperty("Amount")]
    public int Amount { get; set; }
}

public class SkinsPanelLayout
{
    [JsonProperty("SingleItemOffers")]
    public List<string> SingleItemOffers { get; set; }

    [JsonProperty("SingleItemOffersRemainingDurationInSeconds")]
    public int SingleItemOffersRemainingDurationInSeconds { get; set; }
}

