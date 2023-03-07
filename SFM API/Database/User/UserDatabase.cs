﻿using SQLite;

namespace SFM_API.Database.User;

public class UserDatabase : DatabaseBase
{
    public string DatabaseName => "UserDatabase.sqlite";

    private SQLiteConnection Connection;

    public UserDatabase()
    {
        if (!Directory.Exists(DatabaseFolderPath))
        {
            Directory.CreateDirectory(DatabaseFolderPath);
        }

        Connection = new SQLiteConnection(DatabaseFolderPath + DatabaseName);
        Console.WriteLine("UserDatabase created");
    }
}