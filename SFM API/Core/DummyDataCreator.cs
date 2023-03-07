using SFM_API.Database.DatabaseModels.AdminModels;
using SFM_API.Database.DatabaseModels.UserModels;

namespace SFM_API.Core;

public static class DummyDataCreator
{
    public static void CreateDummyData()
    {
        MainManagement.AdminDatabase.AddAdmin(new AdminDataModel( "Sanali", "Test", "asd@asd.co", AdminRoleType.SuperAdministrator));
        MainManagement.UserDatabase.AddUser(new UserDataModel("Sanali", "Test", "asd@asd.co", "Ömer", "Hilal"));
    }
}