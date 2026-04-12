using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class LoginPage(IPage page)
{
    private ILocator UserNameInput => page.Locator("#user-name");
    private ILocator PasswordInput => page.Locator("#password");
    private ILocator LoginButton => page.Locator("#login-button");

    public async Task Open()
    {
        await page.GotoAsync("https://www.saucedemo.com/");
    }
    
    public async Task Login(string userName, string password)
    {
        await UserNameInput.FillAsync(userName);
        await PasswordInput.FillAsync(password);
        await LoginButton.ClickAsync();
    }
}