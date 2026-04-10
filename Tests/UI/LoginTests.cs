namespace DotNetQaFramework.Tests.UI;

public class LoginTests : BaseUiTest
{
    
    
    [Test]
    public async Task User_Can_Login_With_Valid_Credentials()
    {
        await Pages.LoginPage.Open();
        await Pages.LoginPage.Login("standard_user", "secret_sauce");
        
        Assert.That(await Pages.InventoryPage.ShoppingContainerIsVisible(), Is.True);
    }
}