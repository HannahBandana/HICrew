using Microsoft.Identity.Client;
using System;
using System.Linq;
using System.Threading.Tasks;

public class AuthenticationService
{
    private IPublicClientApplication _publicClientApp;

    public AuthenticationService()
    {
        _publicClientApp = PublicClientApplicationBuilder.Create("b8eb2508-c8ff-4886-9c6f-2c2da0e02a44")
            .WithB2CAuthority("https://your-tenant-name.b2clogin.com/your-tenant-name.onmicrosoft.com/B2C_1_susi")
            .WithRedirectUri("msalb8eb2508-c8ff-4886-9c6f-2c2da0e02a44://auth")
            .Build();
    }

    public async Task<AuthenticationResult> SignInAsync()
    {
        var scopes = new string[] { "openid", "offline_access" };
        try
        {
            var accounts = await _publicClientApp.GetAccountsAsync();
            return await _publicClientApp.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                .ExecuteAsync();
        }
        catch (MsalUiRequiredException)
        {
            return await _publicClientApp.AcquireTokenInteractive(scopes)
                .ExecuteAsync();
        }
    }
}
