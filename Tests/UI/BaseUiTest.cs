using DotNetQaFramework.UI;
using Microsoft.Playwright;

namespace DotNetQaFramework.Tests.UI;

public class BaseUiTest
{
    private IBrowser _browser;
    private IPlaywright _playwright;
    private IPage _page;
    protected Pages Pages;

    [SetUp]
    public async Task Setup()
    {   
        Console.WriteLine($"START TEST: {TestContext.CurrentContext.Test.Name}");
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        _page = await _browser.NewPageAsync();
        Pages = new Pages(_page);
    }

    [TearDown]
    public async Task TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            await TakeScreenshot();
        }
        Console.WriteLine($"END TEST: {TestContext.CurrentContext.Test.Name}");
        await _browser.CloseAsync();
        _playwright.Dispose();
    }

    private async Task TakeScreenshot()
    {
        var root = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
        var dir = Path.Combine(root, "reports/screenshots");
        Directory.CreateDirectory(dir);

        var fileName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
        var path = Path.Combine(dir, fileName);

        await _page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = path,
            FullPage = true
        });

        Console.WriteLine($"Screenshot saved: {path}");
    }
}