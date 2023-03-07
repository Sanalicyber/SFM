using System.Text;

namespace SFM_API.Database.DatabaseModels.UserModels;

public class UserDataModel : IDatabaseModel
{
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public UserDataModel(int id, string username, string password, string email, string name, string surname)
    {
        ID = id;
        Username = username;
        Password = password;
        Email = email;
        Name = name;
        Surname = surname;
    }

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