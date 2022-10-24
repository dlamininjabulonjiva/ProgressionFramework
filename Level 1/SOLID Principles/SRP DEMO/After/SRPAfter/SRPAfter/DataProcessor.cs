using System;

namespace SRPAfter
{
    public class DataProcessor
    {
        public void AddUser(User user)
        {
            Console.Write("User with email: " + user.Email + " has been processed");
        }
    }
}
