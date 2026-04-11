using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using Reqnroll;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class InventoryPageSteps
{
    private readonly Context _context;

    public InventoryPageSteps()
    {
        _context = TestHooks.Context;
    }
    
    [When("user adds backpack to cart")]
    public async Task WhenUserAddsBackpackToCart()
    {
        await _context.Pages.InventoryPage.AddBackpackToCart();
    }
    
    [Then("cart should contain (.*) item")]
    public async Task AssertCart(int count)
    {
        Assert.That(await _context.Pages.InventoryPage.GetCartItemsCount(), Is.EqualTo(count));
    }

    [When("user opens cart")]
    public async Task WhenUserOpensCart()
    {
        await _context.Pages.InventoryPage.OpensCart();
    }
}