using Microsoft.Playwright;

namespace DotNetQaFramework;

public class LoginTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task User_Can_Login_With_Valid_Credentials()
    {
        // Playwright
        using var playwright = await Playwright.CreateAsync();
        // Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        // Page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.saucedemo.com/");
        
        await page.FillAsync("#user-name", "standard_user");
        await page.FillAsync("#password", "secret_sauce");
        await page.ClickAsync("#login-button");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "screenshot.png",
        });
        var isVisibleAsync = await page.Locator("text='Swag Labs'").IsVisibleAsync();
        Assert.That(isVisibleAsync, Is.True);
    }
}