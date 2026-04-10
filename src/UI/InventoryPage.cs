using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class InventoryPage(IPage page)
{
    private ILocator ShoppingContainer => page.Locator("#shopping_cart_container");
    
    public async Task<bool> ShoppingContainerIsVisible()
    {
        return await ShoppingContainer.IsVisibleAsync();
    }
}