using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class CardPageSteps
{
    private readonly Context _context;

    public CardPageSteps()
    {
        _context = TestHooks.Context;
    }
 
    [When("user proceeds to checkout")]
    public async Task UserProceedsToCheckout()
    {
        await _context.Pages.CartPage.Checkout();
    }
}