using Application.Method;

namespace Tests;

public class AuthenticationServiceTests
{
    [Fact]
    public void administrator_is_always_authenticated(){
        var service = new AuthenticationService();
        var adminId = 12345;
        Assert.True(service.IsAuthenticated(adminId));
    }

    [Fact]
    public void normalUser_is_not_authenticated_initially(){
        AuthenticationService service = new AuthenticationService();
        int normalUserId = 11111;
        Assert.False(service.IsAuthenticated(normalUserId));
    }
}