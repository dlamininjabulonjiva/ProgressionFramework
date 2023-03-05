using System;

namespace MVCExample.View
{
    public class UserView
    {
        public void PrintUserDetails(int id, string name, string email)
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Email: {email}");
        }
    }
}
