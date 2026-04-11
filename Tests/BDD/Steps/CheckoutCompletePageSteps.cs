using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class CheckoutCompletePageSteps
{
    private readonly Context _context;

    public CheckoutCompletePageSteps()
    {
        _context = TestHooks.Context;
    }

    // =========== Assertions =========== 
    [Then("order confirmation is shown")]
    public async Task ThenOrderConfirmationIsShown()
    {
        Assert.That(await _context.Pages.CheckoutCompletePage.CompleteHeaderIsVisible(), Is.True);
    }
}