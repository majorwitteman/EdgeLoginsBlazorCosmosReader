using Newtonsoft.Json;

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
    public int LoginsCount => Logins?.Length > 0 ? Logins.Length : 0;
}