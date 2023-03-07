using SFM_API.Database.Admin;
using SFM_API.Database.User;
using SFM_API.Logger;

namespace SFM_API.Core;

public static class MainManagement
{
    internal static AdminDatabase AdminDatabase { get; set; }
    internal static UserDatabase UserDatabase { get; set; }
    internal static UserContentDatabase UserContentDatabase { get; set; }

    public static void InitProject()
    {
        AdminDatabase = new AdminDatabase();
        UserDatabase = new UserDatabase();
        UserContentDatabase = new UserContentDatabase();
        DummyDataCreator.CreateDummyData();
        SLogger.Initialize();
    }
}