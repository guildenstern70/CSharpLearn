/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

public class Nullable
{
    public int NullString()
    {
        string? message = null;
        if (message is not null)
        {
            return 0;
        }

        return -1;
    }

    public string IfIsNull()
    {
        string? x = null;
        return x ?? "NeedToCheckforNull";   // Return x if x is not null, else "Need..."
    }

}