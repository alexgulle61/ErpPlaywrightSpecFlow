using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

namespace MortgageCalculator.Pages;

public class CoveragesPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public CoveragesPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    private ILocator nextButton => page.FrameLocator("id=rp-insurance-widget").Locator("xpath=//button[@class='btn btn-primary px-4 px-sm-5']");

    public async Task moveNextPage()
    {
        //await nextButton.ScrollIntoViewIfNeededAsync();
        await nextButton.ClickAsync();
    }
}