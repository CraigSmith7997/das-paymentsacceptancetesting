﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.DAS.Payments.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Provider earnings and payments for a learner with a negotiated price above the fu" +
        "nding band cap")]
    [NUnit.Framework.CategoryAttribute("capping")]
    public partial class ProviderEarningsAndPaymentsForALearnerWithANegotiatedPriceAboveTheFundingBandCapFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "capping.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Provider earnings and payments for a learner with a negotiated price above the fu" +
                    "nding band cap", null, ProgrammingLanguage.CSharp, new string[] {
                        "capping"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("640-AC01-Payment for a DAS learner with a negotiated price above the funding band" +
            " cap")]
        public virtual void _640_AC01_PaymentForADASLearnerWithANegotiatedPriceAboveTheFundingBandCap()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("640-AC01-Payment for a DAS learner with a negotiated price above the funding band" +
                    " cap", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.And("the apprenticeship funding band maximum is 15000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table151 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "version Id",
                        "Provider",
                        "ULN",
                        "start date",
                        "end date",
                        "agreed price",
                        "standard code",
                        "status",
                        "effective from",
                        "effective to"});
            table151.AddRow(new string[] {
                        "1",
                        "1",
                        "provider a",
                        "learner a",
                        "01/08/2017",
                        "01/08/2018",
                        "18000",
                        "50",
                        "active",
                        "01/08/2017",
                        ""});
#line 7
    testRunner.And("the following commitments exist:", ((string)(null)), table151, "And ");
#line hidden
            TechTalk.SpecFlow.Table table152 = new TechTalk.SpecFlow.Table(new string[] {
                        "Provider",
                        "ULN",
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status",
                        "standard code"});
            table152.AddRow(new string[] {
                        "provider a",
                        "learner a",
                        "programme only DAS",
                        "18000",
                        "06/08/2017",
                        "08/08/2018",
                        "",
                        "continuing",
                        "50"});
#line 10
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table152, "When ");
#line hidden
            TechTalk.SpecFlow.Table table153 = new TechTalk.SpecFlow.Table(new string[] {
                        "Provider",
                        "price episode",
                        "negotiated price",
                        "funding cap",
                        "previous funding paid",
                        "price above cap",
                        "effective price for SFA payments"});
            table153.AddRow(new string[] {
                        "provider a",
                        "08/17 onwards",
                        "18000",
                        "15000",
                        "0",
                        "3000",
                        "15000"});
#line 13
    testRunner.Then("the following capping will apply to the price episodes:", ((string)(null)), table153, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table154 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17"});
            table154.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table154.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table154.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table154.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table154.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table154.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table154.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table154.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table154.AddRow(new string[] {
                        "SFA Levy additional payments budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table154.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 16
    testRunner.And("the provider earnings and payments break down as follows:", ((string)(null)), table154, "And ");
#line hidden
            TechTalk.SpecFlow.Table table155 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17"});
            table155.AddRow(new string[] {
                        "On-program",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table155.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "0",
                        "0"});
            table155.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "0",
                        "0"});
            table155.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0"});
            table155.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0"});
            table155.AddRow(new string[] {
                        "Provider disadvantage uplift",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 28
    testRunner.And("the transaction types for the payments are:", ((string)(null)), table155, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("640-AC02-Payment for a non-DAS learner with a negotiated price above the funding " +
            "band cap")]
        public virtual void _640_AC02_PaymentForANon_DASLearnerWithANegotiatedPriceAboveTheFundingBandCap()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("640-AC02-Payment for a non-DAS learner with a negotiated price above the funding " +
                    "band cap", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
    testRunner.Given("the apprenticeship funding band maximum is 15000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table156 = new TechTalk.SpecFlow.Table(new string[] {
                        "Provider",
                        "ULN",
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status",
                        "standard code"});
            table156.AddRow(new string[] {
                        "provider a",
                        "learner a",
                        "programme only non-DAS",
                        "18000",
                        "06/08/2017",
                        "08/08/2018",
                        "",
                        "continuing",
                        "50"});
#line 40
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table156, "When ");
#line hidden
            TechTalk.SpecFlow.Table table157 = new TechTalk.SpecFlow.Table(new string[] {
                        "Provider",
                        "price episode",
                        "negotiated price",
                        "funding cap",
                        "previous funding paid",
                        "price above cap",
                        "effective price for SFA payments"});
            table157.AddRow(new string[] {
                        "provider a",
                        "08/17 onwards",
                        "18000",
                        "15000",
                        "0",
                        "3000",
                        "15000"});
#line 43
    testRunner.Then("the following capping will apply to the price episodes:", ((string)(null)), table157, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table158 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17"});
            table158.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "1000"});
            table158.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "900",
                        "900",
                        "900",
                        "900",
                        "900"});
            table158.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "100",
                        "100",
                        "100",
                        "100",
                        "100"});
            table158.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "900",
                        "900",
                        "900",
                        "900"});
            table158.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "100",
                        "100",
                        "100",
                        "100"});
            table158.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table158.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table158.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table158.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "900",
                        "900",
                        "900",
                        "900",
                        "900"});
            table158.AddRow(new string[] {
                        "SFA Levy additional payments budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table158.AddRow(new string[] {
                        "SFA non-Levy additional payments budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 46
    testRunner.And("the provider earnings and payments break down as follows:", ((string)(null)), table158, "And ");
#line hidden
            TechTalk.SpecFlow.Table table159 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17"});
            table159.AddRow(new string[] {
                        "On-program",
                        "900",
                        "900",
                        "900",
                        "900"});
            table159.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "0",
                        "0"});
            table159.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "0",
                        "0"});
            table159.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0"});
            table159.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0"});
            table159.AddRow(new string[] {
                        "Provider disadvantage uplift",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 59
    testRunner.And("the transaction types for the payments are:", ((string)(null)), table159, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
