using Newtonsoft.Json;

namespace HeadHunter.Models.Auth
{
    public class UserInfo
    {
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("sub")]
        public string Sub { get; set; }
        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }
        [JsonProperty("player_plocale")]
        public object PlayerPlocale { get; set; }
        [JsonProperty("country_at")]
        public long CountryAt { get; set; }
        public Pw Pw { get; set; }
        [JsonProperty("phone_number_verified")]
        public bool PhoneNumberVerified { get; set; }
        [JsonProperty("account_verified")]
        public bool AccountVerified { get; set; }
        [JsonProperty("ppid")]
        public object Ppid { get; set; }
        [JsonProperty("player_locale")]
        public string PlayerLocale { get; set; }
        public Acct Acct { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("jti")]
        public string Jti { get; set; }
        public Affinity Affinity { get; set; }
        public Entitlement Entitlement { get; set; }
        public UserProfileSettings Auth { get; set; }
    }

    public class Pw
    {
        [JsonProperty("cng_at")]
        public long CngAt { get; set; }
        [JsonProperty("reset")]
        public bool Reset { get; set; }
        [JsonProperty("must_reset")]
        public bool MustReset { get; set; }
    }

    public class Acct
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("adm")]
        public bool Adm { get; set; }
        [JsonProperty("game_name")]
        public object GameName { get; set; }
        [JsonProperty("tag_line")]
        public object TagLine { get; set; }
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }
    }

    public class Affinity
    {
        [JsonProperty("pp")]
        public string Region { get; set; }
    }

    public class Entitlement
    {
        public string EntitlementsToken { get; set; }
    }

    public class UserProfileSettings
    {
        public string Puuid { get; set; }
        public string AccessToken { get; set; }
        public string Entitlement { get; set; }
        public string Region { get; set; }
    }
}
