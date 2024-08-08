using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

namespace MortgageCalculator.Pages;

public class ApartmentPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public ApartmentPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    public async Task pickApartment(string apartmentName)
    {
        await page.GetByRole(AriaRole.Link, new PageGetByRoleOptions() { Name = $"{apartmentName}" }).ClickAsync();
    }
}