using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class CheckoutStepTwoPageSteps
{
    private readonly Context _context;

    public CheckoutStepTwoPageSteps()
    {
        _context = TestHooks.Context;
    }

    [When("user finishes purchase")]
    public async Task WhenUserFinishesPurchase()
    {
        await _context.Pages.CheckoutStepTwoPage.FinishCheckout();
    }
}