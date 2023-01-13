using Newtonsoft.Json;

namespace HeadHunter.Models.Pregame;

public class SeasonalBadgeInfo
{
    [JsonProperty("SeasonID")]
    public string SeasonID { get; set; }

    [JsonProperty("NumberOfWins")]
    public int NumberOfWins { get; set; }

    [JsonProperty("WinsByTier")]
    public object WinsByTier { get; set; }

    [JsonProperty("Rank")]
    public int Rank { get; set; }

    [JsonProperty("LeaderboardRank")]
    public int LeaderboardRank { get; set; }
}
