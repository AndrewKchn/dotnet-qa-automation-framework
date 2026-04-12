using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class InventoryPage(IPage page)
{
    private ILocator InventoryList => page.Locator(".inventory_list");
    private ILocator BackpackAddButton => page.Locator("#add-to-cart-sauce-labs-backpack");
    private ILocator BackpackRemoveButton => page.Locator("#remove-sauce-labs-backpack");
    private ILocator BikeLightAddButton => page.Locator("#add-to-cart-sauce-labs-bike-light");
    private ILocator BikeLightRemoveButton => page.Locator("#remove-sauce-labs-bike-light");
    private ILocator CartBadge => page.Locator(".shopping_cart_badge");

    public async Task<bool> InventoryListIsVisible() => await InventoryList.IsVisibleAsync();
    
    public async Task AddBackpackToCart() => await BackpackAddButton.ClickAsync();

    public async Task RemoveBackpackFromCart() => await BackpackRemoveButton.ClickAsync();
    
    public async Task AddBikeLightToCart() => await BikeLightAddButton.ClickAsync();
    public async Task RemoveBikeLightFromCart() => await BikeLightRemoveButton.ClickAsync();

    public async Task<int> GetCartItemsCount()
    {
        if (await CartBadge.IsVisibleAsync())
        {
            var textCount = await CartBadge.TextContentAsync();
            return int.Parse(textCount);
        }

        return 0;
    }
    
    public async Task OpensCart() => await CartBadge.ClickAsync();
}