using DotNetQaFramework.Tests.BDD.Hooks;
using DotNetQaFramework.Tests.BDD.Support;
using TechTalk.SpecFlow;

namespace DotNetQaFramework.Tests.BDD.Steps;

[Binding]
public class CartSteps
{
    private readonly Context _context;

    public CartSteps()
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
}