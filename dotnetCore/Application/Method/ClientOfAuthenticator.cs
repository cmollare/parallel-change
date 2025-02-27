﻿namespace Application.Method;

public class ClientOfAuthenticator
{
    private AuthenticationService authenticationService;

    public static void Main(String[] args) {
        new ClientOfAuthenticator(new AuthenticationService()).Run();
    }

    public ClientOfAuthenticator(AuthenticationService authenticationService) {
        this.authenticationService = authenticationService;
    }

    public void Run() {
        bool authenticated = authenticationService.IsAuthenticated(33);
        Console.WriteLine("33 is authenticated = " + authenticated);
    }
}