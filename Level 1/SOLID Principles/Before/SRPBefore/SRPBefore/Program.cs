namespace SRPBefore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userService = new UserService();
            userService.Register("njdlamini@gmail.com", "21101902");
        }
    }
}
