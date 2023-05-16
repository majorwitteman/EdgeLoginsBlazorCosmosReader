using Newtonsoft.Json;

namespace CosmosReader.Data;

class LoginData
{
    [JsonProperty(PropertyName = "id")]
    public string? Id { get; set; }
    [JsonProperty(PropertyName = "userName")]
    public string? Username { get; set; }
    [JsonProperty(PropertyName = "computerName")]
    public string? ComputerName { get; set; }
    [JsonProperty(PropertyName = "profileName")]
    public string? ProfileName { get; set; }
    public int FileSize { get; set; }
    public Login[]? Logins { get; set; }
    public int LoginsSavedCount => Logins?.Where(l => l.NeverRemember == false).Count() > 0 ? Logins.Where(l => l.NeverRemember == false).Count() : 0;
    public int LoginsBlockedCount => Logins?.Where(l => l.NeverRemember == true).Count() > 0 ? Logins.Where(l => l.NeverRemember == true).Count() : 0;
    public int LoginsTotalCount => Logins?.Count() > 0 ? Logins.Count() : 0;
}