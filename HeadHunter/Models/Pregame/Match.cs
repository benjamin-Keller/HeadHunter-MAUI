using Newtonsoft.Json;

namespace HeadHunter.Models.Pregame;

public class Match
{
    [JsonProperty("ID")]
    public string ID { get; set; }

    [JsonProperty("Version")]
    public long Version { get; set; }

    [JsonProperty("Teams")]
    public List<Team> Teams { get; set; }

    [JsonProperty("AllyTeam")]
    public AllyTeam AllyTeam { get; set; }

    [JsonProperty("EnemyTeam")]
    public object EnemyTeam { get; set; }

    [JsonProperty("ObserverSubjects")]
    public List<object> ObserverSubjects { get; set; }

    [JsonProperty("MatchCoaches")]
    public List<object> MatchCoaches { get; set; }

    [JsonProperty("EnemyTeamSize")]
    public int EnemyTeamSize { get; set; }

    [JsonProperty("EnemyTeamLockCount")]
    public int EnemyTeamLockCount { get; set; }

    [JsonProperty("PregameState")]
    public string PregameState { get; set; }

    [JsonProperty("LastUpdated")]
    public DateTime LastUpdated { get; set; }

    [JsonProperty("MapID")]
    public string MapID { get; set; }

    [JsonProperty("MapSelectPool")]
    public List<object> MapSelectPool { get; set; }

    [JsonProperty("BannedMapIDs")]
    public List<object> BannedMapIDs { get; set; }

    [JsonProperty("CastedVotes")]
    public CastedVotes CastedVotes { get; set; }

    [JsonProperty("MapSelectSteps")]
    public List<object> MapSelectSteps { get; set; }

    [JsonProperty("MapSelectStep")]
    public int MapSelectStep { get; set; }

    [JsonProperty("Team1")]
    public string Team1 { get; set; }

    [JsonProperty("GamePodID")]
    public string GamePodID { get; set; }

    [JsonProperty("Mode")]
    public string Mode { get; set; }

    [JsonProperty("VoiceSessionID")]
    public string VoiceSessionID { get; set; }

    [JsonProperty("MUCName")]
    public string MUCName { get; set; }

    [JsonProperty("QueueID")]
    public string QueueID { get; set; }

    [JsonProperty("ProvisioningFlowID")]
    public string ProvisioningFlowID { get; set; }

    [JsonProperty("IsRanked")]
    public bool IsRanked { get; set; }

    [JsonProperty("PhaseTimeRemainingNS")]
    public long PhaseTimeRemainingNS { get; set; }

    [JsonProperty("StepTimeRemainingNS")]
    public int StepTimeRemainingNS { get; set; }

    [JsonProperty("altModesFlagADA")]
    public bool AltModesFlagADA { get; set; }

    [JsonProperty("TournamentMetadata")]
    public object TournamentMetadata { get; set; }

    [JsonProperty("RosterMetadata")]
    public object RosterMetadata { get; set; }
}
