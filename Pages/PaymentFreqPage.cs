namespace MortgageCalculator.Pages;
using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

public class PaymentFreqPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public PaymentFreqPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    private ILocator nextButton => page.FrameLocator("id=rp-insurance-widget").Locator("id=nextButton");

    public async Task moveNextPage()
    {
        await nextButton.ClickAsync();
    }
}