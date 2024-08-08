namespace MortgageCalculator.Pages;
using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

public class PackagesPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public PackagesPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    private ILocator unitSearchTextBox => page.FrameLocator("id=rp-insurance-widget").Locator("xpath=//input[@name='unitSelector']");
    private ILocator unitPick => page.FrameLocator("id=rp-insurance-widget").Locator("xpath=//button[@class='dropdown-item'][1]");

    private ILocator purchaseButton =>
        page.FrameLocator("id=rp-insurance-widget").Locator("xpath=//button[@class='btn btn-primary px-4 px-sm-5 w-100']");

    public async Task pickAUnit(string unitNumber)
    {
        await unitSearchTextBox.FillAsync(unitNumber);
        await unitPick.ClickAsync();
    }

    public async Task pickAPackage(string package)
    {
        await purchaseButton.ClickAsync();
    }
}