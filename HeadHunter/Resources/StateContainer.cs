using Blazored.LocalStorage;
using HeadHunter.Models.Auth;

namespace HeadHunter.Resources;

public class StateContainer
{
    public event Func<Task> OnProfileChangeAsync;
    public event Action OnStateChange;
    private void NotifyStateChanged() => OnStateChange?.Invoke();

    public string Username { get; set; }
    public UserInfo User { get; set; }
    public UserProfileSettings UserSettings { get; set; }

    public async Task InitAsync(UserInfo user = null, UserProfileSettings settings = null, string username = null)
    {
        if (user is not null)
            User = user;
        if (settings is not null)
            UserSettings = settings;
        if (user is not null && settings is not null)
            User.Auth = UserSettings;
        if (!string.IsNullOrWhiteSpace(username))
            Username = username;

        NotifyStateChanged();
    }
}

