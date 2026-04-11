using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class CartPage(IPage page)
{
    private ILocator CheckoutButton => page.Locator("#checkout");
    
    public async Task Checkout() => await CheckoutButton.ClickAsync();
}