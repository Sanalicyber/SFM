using SFM_API.Database;
using SFM_API.Database.Admin;
using SFM_API.Database.User;

namespace SFM_API.Core;

public static class MainManagement
{
    private static List<DatabaseBase> _databases = new List<DatabaseBase>();

    public static void InitProject()
    {
        _databases.Add(new AdminDatabase());
        _databases.Add(new UserDatabase());
        _databases.Add(new UserContentDatabase());
    }
}