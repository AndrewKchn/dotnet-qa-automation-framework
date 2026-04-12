using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class CheckoutCompletePage(IPage page)
{
    private ILocator CompleteHeader => page.Locator(".complete-header");
    
    public async Task<bool> CompleteHeaderIsVisible() => await CompleteHeader.IsVisibleAsync();
}