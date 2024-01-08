namespace Application.Method;

public class AuthenticationService
{
    public bool IsAuthenticated(int id){
        return id == 12345;
    }
}