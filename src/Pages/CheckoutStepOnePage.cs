using Microsoft.Playwright;

namespace DotNetQaFramework.UI;

public class CheckoutStepOnePage(IPage page)
{
    private ILocator FirstNameInput => page.Locator("#first-name");
    private ILocator LastNameInput => page.Locator("#last-name");
    private ILocator PostalCodeInput => page.Locator("#postal-code");
    private ILocator ContinueButton => page.Locator("#continue");

    public async Task FillUserData(string firstName, string lastName, string postalCode)
    {
        await FirstNameInput.FillAsync(firstName);
        await LastNameInput.FillAsync(lastName);
        await PostalCodeInput.FillAsync(postalCode);
        await ContinueButton.ClickAsync();
    }
}