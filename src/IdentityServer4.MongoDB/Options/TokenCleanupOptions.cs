﻿namespace IdentityServer4.MongoDB.Options
{
    public class TokenCleanupOptions
    {
        public int Interval { get; set; } = 60;
    }
}