using DotNetQaFramework.Tests.BDD.Support;
using DotNetQaFramework.UI;
using Microsoft.Playwright;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Hooks;

[Binding]
public class TestHooks
{
    public static Context Context;

    private IPlaywright _playwright;
    private IBrowser _browser;

    [BeforeScenario]
    public async Task Setup()
    {
        Context = new Context();

        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new()
        {
            Headless = true
        });

        Context.Page = await _browser.NewPageAsync();
        Context.Pages = new Pages(Context.Page);
    }

    [AfterScenario]
    public async Task TearDown(ScenarioContext scenario)
    {   
        if (scenario.TestError != null)
        {
            await TakeScreenshot(scenario);
        }
        await _browser.CloseAsync();
        _playwright.Dispose();
    }
    
    private async Task TakeScreenshot(ScenarioContext scenario)
    {
        var root = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
        var dir = Path.Combine(root, "reports/screenshots");
        Directory.CreateDirectory(dir);

        var fileName = $"{scenario.ScenarioInfo.Title}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
        var path = Path.Combine(dir, fileName);

        await Context.Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = path,
            FullPage = true
        });

        Console.WriteLine($"Screenshot saved: {path}");
    }
}