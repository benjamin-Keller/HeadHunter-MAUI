using Newtonsoft.Json;

namespace HeadHunter.Models.Pregame;

public class Player
{
    [JsonProperty("Subject")]
    public string Subject { get; set; }

    [JsonProperty("CharacterID")]
    public string CharacterID { get; set; }

    [JsonProperty("CharacterSelectionState")]
    public string CharacterSelectionState { get; set; }

    [JsonProperty("PregamePlayerState")]
    public string PregamePlayerState { get; set; }

    [JsonProperty("CompetitiveTier")]
    public int CompetitiveTier { get; set; }

    [JsonProperty("PlayerIdentity")]
    public PlayerIdentity PlayerIdentity { get; set; }

    [JsonProperty("SeasonalBadgeInfo")]
    public SeasonalBadgeInfo SeasonalBadgeInfo { get; set; }

    [JsonProperty("IsCaptain")]
    public bool IsCaptain { get; set; }
}
