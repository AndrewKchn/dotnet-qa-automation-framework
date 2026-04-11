using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class LoginPageSteps
{
    private readonly Context _context;
    
    public LoginPageSteps()
    {
        _context = TestHooks.Context;
    }

    [Given("user is logged in")]
    public async Task Login()
    {
        await _context.Pages.LoginPage.Open();
        await _context.Pages.LoginPage.Login("standard_user", "secret_sauce");
    }
}