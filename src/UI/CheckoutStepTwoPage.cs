using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class CheckoutStepTwoPage(IPage page)
{
    private ILocator FinishButton => page.Locator("#finish");

    public async Task FinishCheckout() => await FinishButton.ClickAsync();
}