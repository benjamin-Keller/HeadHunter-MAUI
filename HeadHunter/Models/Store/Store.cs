using Newtonsoft.Json;

namespace HeadHunter.Models.Store;

public class Store
{
    [JsonProperty("FeaturedBundle")]
    public FeaturedBundle FeaturedBundle { get; set; }

    [JsonProperty("SkinsPanelLayout")]
    public SkinsPanelLayout SkinsPanelLayout { get; set; }
}
