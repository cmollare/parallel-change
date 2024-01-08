namespace Application.Method;

public class AnotherClientOfAuthenticator
{
    public void UnusedClientCode() {
        try {
            new AuthenticationService().IsAuthenticated(3545);
        } catch (Exception) {
            // ignored
        }
    }
}