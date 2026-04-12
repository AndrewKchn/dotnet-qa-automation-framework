namespace DotNetQaFramework.Tests.UI;

public class InventoryTests : BaseUiTest
{
    [SetUp]
    public async Task LogIn()
    {
        await Pages.LoginPage.Open();
        await Pages.LoginPage.Login("standard_user", "secret_sauce");
    }

    [Test]
    [Explicit("Moved to Reqnroll")]
    public async Task User_Can_Add_Item_To_Cart()
    {
        await Pages.InventoryPage.AddBackpackToCart();

        Assert.That(await Pages.InventoryPage.GetCartItemsCount(), Is.EqualTo(1));
    }

    [Test]
    [Explicit("Moved to Reqnroll")]
    public async Task User_Can_Add_Multiple_Items_To_Cart()
    {
        await Pages.InventoryPage.AddBackpackToCart();
        await Pages.InventoryPage.AddBikeLightToCart();

        Assert.That(await Pages.InventoryPage.GetCartItemsCount(), Is.EqualTo(2));
    }

    [Test]
    [Explicit("Moved to Reqnroll")]
    public async Task User_Can_Remove_Item_From_Cart()
    {
        await Pages.InventoryPage.AddBackpackToCart();
        await Pages.InventoryPage.AddBikeLightToCart();
        await Pages.InventoryPage.RemoveBackpackFromCart();

        Assert.That(await Pages.InventoryPage.GetCartItemsCount(), Is.EqualTo(1));
    }
}