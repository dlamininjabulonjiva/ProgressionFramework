# JWT Auth demo
- In this example, I have implemented a Token Based Authentication with Asp.net Core Web API and JWT (JSON Web Token).  
- This Web API project has the below endpoints:
    - api/Members/authenticate – Authenticate Member Credential and send Access token for subsequence request.
    - api/Members – Return a List of all Members.
    - api/Members/id - Filters members by id and return the member for that id.
- The following are the Nuget packages that I had to install in order to achieve my goal on this project:
    - Microsoft.AspNetCore.Authentication - for Authentication
    - System.IdentityModel.Tokens.Jwt - to create JWT Token
    - Then I installed the Microsoft.AspNetCore.Authentication.JwtBearer