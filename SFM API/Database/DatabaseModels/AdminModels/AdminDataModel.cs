using System.Text;
using SQLite;

namespace SFM_API.Database.DatabaseModels.AdminModels;

public class AdminDataModel : BaseDatabaseModel
{
    [Unique] public string Username { get; set; }
    public string Password { get; set; }
    [Unique] public string Email { get; set; }
    public AdminRoleType Role { get; set; }

    public AdminDataModel(string username, string password, string email, AdminRoleType role)
    {
        Username = username;
        Password = password;
        Email = email;
        Role = role;
    }

    public AdminDataModel() { }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("ID: ").Append(ID).AppendLine();
        builder.Append("Username: ").Append(Username).AppendLine();
        builder.Append("Password: ").Append(Password).AppendLine();
        builder.Append("Email: ").Append(Email).AppendLine();
        builder.Append("Role: ").Append(Role).AppendLine();
        return builder.ToString();
    }
}