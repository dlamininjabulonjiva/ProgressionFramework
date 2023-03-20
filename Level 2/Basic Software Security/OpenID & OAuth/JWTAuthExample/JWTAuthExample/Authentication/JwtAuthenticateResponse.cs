namespace JWTAuthExample.Authentication
{
    public class JwtAuthenticateResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }

        public JwtAuthenticateResponse(string username, string token)
        {
            Username = username;
            Token = token;
        }
    }
}
