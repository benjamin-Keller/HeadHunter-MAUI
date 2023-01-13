using Newtonsoft.Json;

namespace HeadHunter.Models.Pregame;

public class SessionMetadata
{
    [JsonProperty("Subject")]
    public string Subject { get; set; }

    [JsonProperty("MatchID")]
    public string MatchID { get; set; }

    [JsonProperty("Version")]
    public long Version { get; set; }
}

