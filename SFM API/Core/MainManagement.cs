﻿using SFM_API.Database.Admin;
using SFM_API.Database.User;

namespace SFM_API.Core;

public static class MainManagement
{
    internal static AdminDatabase AdminDatabase => new ();
    internal static UserDatabase UserDatabase => new ();
    internal static UserContentDatabase UserContentDatabase => new ();

    public static void InitProject()
    {
        DummyDataCreator.CreateDummyData();
    }
}