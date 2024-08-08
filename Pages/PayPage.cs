namespace MortgageCalculator.Pages;
using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

public class PayPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public PayPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    public ILocator nameOnTheCard => page.FrameLocator("id=rp-insurance-widget").Locator("id=cardName");

    public ILocator payButton => page.FrameLocator("id=rp-insurance-widget").Locator("id=payButton");
}