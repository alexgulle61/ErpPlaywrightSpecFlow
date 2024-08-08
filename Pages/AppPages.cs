using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;

namespace MortgageCalculator.Pages
{
    public class AppPages
    {
        public readonly ISpecFlowOutputHelper SpecFlowOutputHelper;
        public readonly HomePage HomePage;
        public readonly ApartmentPage ApartmentPage;
        public readonly PersonalInfoPage PersonalInfoPage;
        public readonly PackagesPage PackagesPage;
        public readonly CoveragesPage CoveragesPage;
        public readonly ScreeningPage ScreeningPage;
        public readonly OccupantsPage OccupantsPage;
        public readonly PaymentFreqPage PaymentFreqPage;
        public readonly PayPage PayPage;
        public readonly ERP_HomePage ErpHomePage;


        public AppPages(ISpecFlowOutputHelper specFlowOutputHelper, HomePage homePage, ApartmentPage apartmentPage, PersonalInfoPage personalInfoPage,
            PackagesPage packagesPage, CoveragesPage coveragesPage, ScreeningPage screeningPage, OccupantsPage occupantsPage,
            PaymentFreqPage paymentFreqPage, PayPage payPage, ERP_HomePage erpHomePage)
        {

            this.HomePage = homePage;
            this.SpecFlowOutputHelper = specFlowOutputHelper;
            this.ApartmentPage = apartmentPage;
            this.PersonalInfoPage = personalInfoPage;
            this.PackagesPage = packagesPage;
            this.CoveragesPage = coveragesPage;
            this.ScreeningPage = screeningPage;
            this.OccupantsPage = occupantsPage;
            this.PaymentFreqPage = paymentFreqPage;
            this.PayPage = payPage;
            this.ErpHomePage = erpHomePage;

        }
        
    }
}
