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

    [Given("user opens login page")]
    public async Task UserOpensLoginPage()
    {
        await _context.Pages.LoginPage.Open();
    }

    [When("user logs in with credentials")]
    public async Task UserLogsInWithCredentials(Reqnroll.Table table)
    {
        {
            var data = table.Rows[0];

            var userName = data["Username"];
            var password = data["Password"];

            await _context.Pages.LoginPage.Login(userName, password);
        }
    }
}