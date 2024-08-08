namespace MortgageCalculator.Pages;
using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

public class ScreeningPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public ScreeningPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }
    
    private ILocator nextButton => page.FrameLocator("id=rp-insurance-widget").Locator("id=nextButton");

    public async Task selectNo()
    {
        await page.FrameLocator("id=rp-insurance-widget").Locator("xpath=(//select[@name='questionAnswer'])[1]")
            .SelectOptionAsync("No");
        await page.FrameLocator("id=rp-insurance-widget").Locator("xpath=(//select[@name='questionAnswer'])[2]")
            .SelectOptionAsync("No");
        await nextButton.ClickAsync();
    }
}