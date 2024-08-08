namespace MortgageCalculator.Pages;
using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

public class PersonalInfoPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public PersonalInfoPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    private ILocator firstNameTextBox => page.Locator("id=firstName");
    private ILocator lastNameTextBox => page.Locator("id=lastName");
    private ILocator emailTextBox => page.Locator("id=email");
    private ILocator continueButton => page.Locator("id=Continue");

    public async Task fillOutPersonalInfo(string firstName, string lastName, string email)
    {
        await firstNameTextBox.FillAsync(firstName);
        await lastNameTextBox.FillAsync(lastName);
        await emailTextBox.FillAsync(email);
        await continueButton.ClickAsync();
    }
}