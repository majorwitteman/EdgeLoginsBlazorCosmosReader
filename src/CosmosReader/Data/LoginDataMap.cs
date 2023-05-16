using CsvHelper.Configuration;

namespace CosmosReader.Data;

class LoginDataMap : ClassMap<LoginData>
{
    public LoginDataMap()
    {
        Map(m => m.Username).Index(0).Name("username");
        Map(m => m.ComputerName).Index(1).Name("computerName");
        Map(m => m.ProfileName).Index(2).Name("profileName");
        Map(m => m.LoginsSavedCount).Index(3).Name("countOfSaved");
        Map(m => m.LoginsBlockedCount).Index(4).Name("countOfBlocked");
    }
}