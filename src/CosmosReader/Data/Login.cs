using Newtonsoft.Json;

namespace CosmosReader.Data;

class Login
{
    [JsonProperty(PropertyName = "origin_url")]
    public Uri? OriginUrl { get; set; }
    [JsonProperty(PropertyName = "username_value")]
    public string? UserName { get; set; }
    [JsonProperty(PropertyName = "blacklisted_by_user")]
    public bool? NeverRemember { get; set; }
}