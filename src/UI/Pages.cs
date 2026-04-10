using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class Pages
{
    public LoginPage LoginPage { get; }
    public InventoryPage InventoryPage { get; }

    public Pages(IPage page)
    {
        LoginPage = new LoginPage(page);
        InventoryPage = new InventoryPage(page);
    }
}