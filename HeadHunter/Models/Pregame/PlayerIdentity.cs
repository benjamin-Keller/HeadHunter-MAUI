using Newtonsoft.Json;

namespace HeadHunter.Models.Pregame;

public class PlayerIdentity
{
    [JsonProperty("Subject")]
    public string Subject { get; set; }

    [JsonProperty("PlayerCardID")]
    public string PlayerCardID { get; set; }

    [JsonProperty("PlayerTitleID")]
    public string PlayerTitleID { get; set; }

    [JsonProperty("AccountLevel")]
    public int AccountLevel { get; set; }

    [JsonProperty("PreferredLevelBorderID")]
    public string PreferredLevelBorderID { get; set; }

    [JsonProperty("Incognito")]
    public bool Incognito { get; set; }

    [JsonProperty("HideAccountLevel")]
    public bool HideAccountLevel { get; set; }
}
