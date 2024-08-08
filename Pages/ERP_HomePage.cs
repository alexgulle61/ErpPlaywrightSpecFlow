using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

namespace MortgageCalculator.Pages;

public class ERP_HomePage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public ERP_HomePage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    public ILocator HomePageHeader => page.GetByRole(AriaRole.Heading, new() { Name = "eRenterPlan - Insurance for Renters" });
    
    public ILocator acceptCookies => page.GetByRole(AriaRole.Button, new() { Name = "Accept All Cookies" });
    public ILocator zipCodeSearch => page.Locator("id=postalCode");
    public ILocator getFreeQuoteButton => page.Locator("id=Go");

    public async Task AcceptCookies()
    {
        await acceptCookies.ClickAsync();
    }
    

    public async Task putZipcode(string zipCode)
    {
        await zipCodeSearch.FillAsync(zipCode);
        await getFreeQuoteButton.ClickAsync();
    }
}