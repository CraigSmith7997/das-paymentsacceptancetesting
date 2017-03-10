﻿using SFA.DAS.Payments.AcceptanceTests.Refactoring.Contexts;
using SFA.DAS.Payments.AcceptanceTests.Refactoring.ExecutionManagers;
using SFA.DAS.Payments.AcceptanceTests.Refactoring.TableParsers;
using TechTalk.SpecFlow;

namespace SFA.DAS.Payments.AcceptanceTests.Refactoring.StepDefinitions
{
    [Binding]
    public class SubmissionSteps
    {
        public SubmissionSteps(CommitmentsContext commitmentsContext, SubmissionContext submissionsContext, LookupContext lookupContext)
        {
            CommitmentsContext = commitmentsContext;
            SubmissionsContext = submissionsContext;
            LookupContext = lookupContext;
        }
        public SubmissionContext SubmissionsContext { get; }
        public CommitmentsContext CommitmentsContext { get; }
        public LookupContext LookupContext { get; }


        [When("an ILR file is submitted with the following data:")]
        [When(@"an ILR file is submitted every month with the following data:")] //Duplicate?
        public void WhenAnIlrFileIsSubmitted(Table ilrDetails)
        {
            ParseIlrTableAndSubmit(ilrDetails);
        }

        [When("the providers submit the following ILR files:")] //Duplicate?
        public void WhenMultipleIlrFilesAreSubmitted(Table ilrDetails)
        {
            ParseIlrTableAndSubmit(ilrDetails);
        }

        [When("an ILR file is submitted for the first time on (.*) with the following data:")]
        [When(@"an ILR file is submitted on (.*) with the following data:")] // what is the purpose of the dates?
        public void WhenIlrSubmittedOnSpecificDate(string specSumissionDate, Table ilrDetails)
        {
            ParseIlrTableAndSubmit(ilrDetails);
        }

        [When("the Contract type in the ILR is:")]
        public void WhenTheContractTypeInTheIlrIs(Table contractTypes)
        {
            ContractTypeTableParser.ParseContractTypesIntoContext(SubmissionsContext, contractTypes, LookupContext);
        }

        [When("the employment status in the ILR is:")]
        public void WhenTheEmploymentStatusInTheIlrIs(Table contractTypes)
        {
            //TODO
        }



        private void ParseIlrTableAndSubmit(Table ilrDetails)
        {
            IlrTableParser.ParseIlrTableIntoContext(SubmissionsContext, ilrDetails);
            SubmissionsContext.SubmissionResults = SubmissionManager.SubmitIlrAndRunMonthEndAndCollateResults(SubmissionsContext.IlrLearnerDetails, LookupContext);
        }
    }
}
