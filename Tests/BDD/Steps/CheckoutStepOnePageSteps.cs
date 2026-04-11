using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class CheckoutStepOnePageSteps
{
    private readonly Context _context;

    public CheckoutStepOnePageSteps()
    {
        _context = TestHooks.Context;
    }

    [When("user fills checkout information:")]
    public async Task FillCheckout(Table table)
    {
        var data = table.Rows[0];

        var firstName = data["FirstName"];
        var lastName = data["LastName"];
        var zip = data["Zip"];

        await _context.Pages.CheckoutStepOnePage.FillUserData(firstName, lastName, zip);
    }
}