namespace MortgageCalculator.Pages;
using Microsoft.Playwright;
using MortgageCalculator.StepDefinitions;
using TechTalk.SpecFlow.Infrastructure;

public class OccupantsPage
{
    private IPage page;
    private ISpecFlowOutputHelper specFlowOutputHelper;

    public OccupantsPage(ISpecFlowOutputHelper specFlowOutputHelper, Hooks hooks)
    {
        this.specFlowOutputHelper = specFlowOutputHelper;
        page = hooks.page;
    }

    private ILocator phoneNumberTextBox => page.FrameLocator("id=rp-insurance-widget").Locator("id=primaryResidentPhone");
    private ILocator nextButton => page.FrameLocator("id=rp-insurance-widget").Locator("id=nextButton");
    private ILocator dateOfBirthTextBox => page.FrameLocator("id=rp-insurance-widget").Locator("id=primaryResidentDOB");

    public async Task pickDateOfBirth(string dob) //Thursday, August 3, 2006
    {
        await dateOfBirthTextBox.ClickAsync();
        await page.FrameLocator("id=rp-insurance-widget").Locator($"xpath=//div[@aria-label='{dob}']//div").ClickAsync();
    }

    public async Task putPhoneNumebr(string phoneNumber)
    {
        await phoneNumberTextBox.FillAsync(phoneNumber);
        await nextButton.ClickAsync();
    }
}