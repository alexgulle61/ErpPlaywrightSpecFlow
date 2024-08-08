using Microsoft.Playwright;
using MortgageCalculator.Pages;
using TechTalk.SpecFlow.Infrastructure;

namespace MortgageCalculator.StepDefinitions;
[Binding]
public class ErpStepDefinitions
{
    public IPage page;
    public AppPages appPages;
    public ISpecFlowOutputHelper outputHelper;
    public ScenarioContext scenarioContext;
    public ErpStepDefinitions(AppPages appPages, ISpecFlowOutputHelper specFlowOutputHelper, ScenarioContext scenarioContext, Hooks hooks )
    {
        this.appPages = appPages;
        this.outputHelper = specFlowOutputHelper;
        this.scenarioContext = scenarioContext;
        this.page = hooks.page;              
    }
    
    [Given(@"User is on")]
        public async Task GivenUserIsOn()
        {
            await appPages.ErpHomePage.AcceptCookies();
            //await Expect(appPages.ErpHomePage.HomePageHeader).ToBeVisibleAsync();
            //Assert.Contains(title, url);
        }

        [When(@"User puts a '(.*)'")]
        public async Task WhenUserPutsA(string zipCode)
        {
            await appPages.ErpHomePage.putZipcode(zipCode);
        }

        [When(@"User picks an apartment '(.*)'")]
        public async Task WhenUserPicksAn(string apartment)
        { 
            await appPages.ApartmentPage.pickApartment(apartment);
        }

        [When(@"User puts personal information '(.*)', '(.*)', '(.*)'")]
        public async Task WhenUserPutsPersonalInformation(string firstName, string lastName, string email)
        {
            await appPages.PersonalInfoPage.fillOutPersonalInfo(firstName, lastName, email);
        }

        [When(@"User picks unitNumber '(.*)'")]
        public async Task WhenUserPicksAUnitNumber(string unitNumber)
        {
            await appPages.PackagesPage.pickAUnit(unitNumber);
        }

        [When(@"User picks package '(.*)'")]
        public async Task WhenUserPicksAPackage(string package)
        {
            await appPages.PackagesPage.pickAPackage(package);
        }

        [When(@"User skips the additional coverages page")]
        public async Task WhenUserSkipsAdditionalCoveragesPage()
        {
            await appPages.CoveragesPage.moveNextPage();
        }

        [When(@"User passes the insurance screening page")]
        public async Task WhenUserSelectsOnInsuranceScreeningPage()
        {
            await appPages.ScreeningPage.selectNo();
        }

        [When(@"User puts '(.*)' and '(.*)'")]
        public async Task WhenUserPutsBirthdayAndPhoneNumber(string birthday, string phoneNumber)
        {
            await appPages.OccupantsPage.pickDateOfBirth(birthday);
            await appPages.OccupantsPage.putPhoneNumebr(phoneNumber);
        }

        [When(@"User picks '(.*)'")]
        public async Task WhenUserPicksPaymentFrequency(string paymentFrequency)
        {
            await appPages.PaymentFreqPage.moveNextPage();
        }

        [When(@"User fills out CC information on the payment page '(.*)'")]
        public async Task WhenUserFillsOutCCInformationOnPaymentPage(string name)
        {
            await appPages.PayPage.nameOnTheCard.FillAsync(name);
        }

        [Then(@"User is able to click on the Pay Button")]
        public async Task ThenUserIsAbleToClickOnPayButton()
        { 
            Assert.True( await appPages.PayPage.payButton.IsVisibleAsync());
        }
}