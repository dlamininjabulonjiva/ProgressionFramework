using MVCExample.Controller;
using MVCExample.Model;
using MVCExample.View;

namespace MVCExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a User and UserView objects
            var user = new User() { Id = 1, Name = "John Cena", Email = "john.cena@example.com" };
            var userView = new UserView();

            // Create a UserController object
            var userController = new UserController(user, userView);

            // Print user details
            userController.PrintUserDetails();

            // Update user details
            userController.UpdateUserDetails(2, "Jane Cole", "jane.cole@example.com");

            // Print updated user details
            userController.PrintUserDetails();
        }
    }
}