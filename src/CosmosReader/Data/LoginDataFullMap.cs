using CsvHelper.Configuration;

namespace CosmosReader.Data;

class LoginDataFullMap : ClassMap<LoginDataFull>
{
    public LoginDataFullMap()
    {
        Map(m => m.Username).Index(0).Name("username");
        Map(m => m.ComputerName).Index(1).Name("computerName");
        Map(m => m.ProfileName).Index(2).Name("profileName");
        Map(m => m.OriginUrl).Index(3).Name("originUrl");
        Map(m => m.LoginUsername).Index(4).Name("loginUsername");
        Map(m => m.LoginNeverRemember).Index(5).Name("loginNeverRemember");
    }
}