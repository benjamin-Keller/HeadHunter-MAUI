namespace HeadHunter.Pages.Auth;

public partial class LoginManager
{
    private LoginType _loginType { get; set; }

    private void SetLoginType(LoginType type) => _loginType = type;
}

public enum LoginType
{
    Local,
    Riot
}