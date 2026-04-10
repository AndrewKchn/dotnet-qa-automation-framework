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
        await _browser.CloseAsync();
        _playwright.Dispose();
    }
}