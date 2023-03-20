namespace JWTAuthExample.Authentication
{
    public interface IJwtAuthenticate
    {
        JwtAuthenticateResponse? Authentication(JwtAuthenticateRequest request);
    }
}
