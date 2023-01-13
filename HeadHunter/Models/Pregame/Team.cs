using Newtonsoft.Json;

namespace HeadHunter.Models.Pregame;

public class Team
{
    [JsonProperty("TeamID")]
    public string TeamID { get; set; }

    [JsonProperty("Players")]
    public List<Player> Players { get; set; }
}
