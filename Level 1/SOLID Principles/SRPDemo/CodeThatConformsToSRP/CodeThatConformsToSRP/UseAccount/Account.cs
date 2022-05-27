using System;

namespace CodeThatConformsToSRP.UseAccount
{
    public class Account
    {
        public string? Username { get; set; }
        public string? IdNumber { get; set; }
        public string? Password { get; set; }
        public decimal OpeningBalance { get; set; }
    }
}
