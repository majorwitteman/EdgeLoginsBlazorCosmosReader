using Newtonsoft.Json;

namespace CosmosReader.Data;

class LoginDataFull
{
    public string? Username { get; set; }
    public string? ComputerName { get; set; }
    public string? ProfileName { get; set; }
    public string? OriginUrl { get; set; }
    public string? LoginUsername { get; set; }
    public bool? LoginNeverRemember{ get; set; }

    internal static List<LoginDataFull> GetFullData (LoginData data)
    {
        List<LoginDataFull> results = new();
        if (data.Logins is null) { return new List<LoginDataFull>(); }
        foreach (var l in data.Logins)
        {
            var obj = new LoginDataFull {
                Username = data.Username,
                ComputerName = data.ComputerName,
                ProfileName = data.ProfileName,
                OriginUrl = l.OriginUrl,
                LoginUsername = l.UserName,
                LoginNeverRemember = l.NeverRemember
            };
            results.Add(obj);
        }
        return results;
    }
}