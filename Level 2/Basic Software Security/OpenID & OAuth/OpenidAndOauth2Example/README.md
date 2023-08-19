# Openid and OAuth2
How to seamlessly integrate the HttpClients with OpenId Connect and OAuth 2.0 auth.

This example has aimed at presenting how we can seamlessly integrate with authentication and authorization on HttpClient via the OpenId Connect 2.0 and OAuth 2.0 protocols.
The set up uses the IdentityModel.AspNetCore library for configuring this flow on a backchannel HttpClient connected to the regular HttpClient injected in the code.
Further, this example has showed how to integrate with a separate authorization schema for our own web API, and how this can be configured smoothly, running alongside the backchannel HttpClient.