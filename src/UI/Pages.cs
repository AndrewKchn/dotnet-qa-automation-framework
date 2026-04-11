using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class Pages
{
    public LoginPage LoginPage { get; }
    public InventoryPage InventoryPage { get; }
    public CartPage CartPage { get; }
    public CheckoutStepOnePage CheckoutStepOnePage { get; }
    public CheckoutStepTwoPage CheckoutStepTwoPage { get; }
    public CheckoutCompletePage CheckoutCompletePage { get; }

    public Pages(IPage page)
    {
        LoginPage = new LoginPage(page);
        InventoryPage = new InventoryPage(page);
        CartPage = new CartPage(page);
        CheckoutStepOnePage = new CheckoutStepOnePage(page);
        CheckoutStepTwoPage = new CheckoutStepTwoPage(page);
        CheckoutCompletePage = new CheckoutCompletePage(page);
    }
}