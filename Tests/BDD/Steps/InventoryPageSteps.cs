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
    public async Task UserAddsBackpackToCart()
    {
        await _context.Pages.InventoryPage.AddBackpackToCart();
    }

    [When("user opens cart")]
    public async Task UserOpensCart()
    {
        await _context.Pages.InventoryPage.OpensCart();
    }

    [When("user adds bike light to cart")]
    public async Task UserAddsBikeLightToCart()
    {
        await _context.Pages.InventoryPage.AddBikeLightToCart();
    }
    
    [When("user removes backpack from cart")]
    public async Task UserRemovesBackpackFromCart()
    {
        await _context.Pages.InventoryPage.RemoveBackpackFromCart();
    }

    // =========== Assertions =========== 
    [Then("cart should contain (.*) item")]
    public async Task CartShouldContain(int expectedCount)
    {
        Assert.That(await _context.Pages.InventoryPage.GetCartItemsCount(), Is.EqualTo(expectedCount));
    }

    [Then("inventory page is displayed")]
    public async Task InventoryPageIsDisplayed()
    {
        Assert.That(await _context.Pages.InventoryPage.InventoryListIsVisible(), Is.True);
    }

    [Then("cart item count is {int}")]
    public async Task CartItemCountIs(int expectedCount)
    {
        Assert.That(await _context.Pages.InventoryPage.GetCartItemsCount(), Is.EqualTo(expectedCount));
    }

   
}