using System.Text;
using SQLite;

namespace SFM_API.Database.DatabaseModels.UserModels;

public class UserDataModel : BaseDatabaseModel
{
    [Unique] public string Username { get; set; }
    public string Password { get; set; }
    [Unique] public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public UserDataModel(string username, string password, string email, string name, string surname)
    {
        Username = username;
        Password = password;
        Email = email;
        Name = name;
        Surname = surname;
    }

    public UserDataModel() { }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("ID: ").Append(ID).AppendLine();
        builder.Append("Username: ").Append(Username).AppendLine();
        builder.Append("Password: ").Append(Password).AppendLine();
        builder.Append("Email: ").Append(Email).AppendLine();
        builder.Append("Name: ").Append(Name).AppendLine();
        builder.Append("Surname: ").Append(Surname).AppendLine();
        return builder.ToString();
    }
}