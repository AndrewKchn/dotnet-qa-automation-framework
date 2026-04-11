using DotNetQaFramework.UI;
using Microsoft.Playwright;

namespace DotNetQaFramework.Tests.BDD.Support;

public class Context
{
    public Pages Pages { get; set; }
    public IPage Page { get; set; }
}