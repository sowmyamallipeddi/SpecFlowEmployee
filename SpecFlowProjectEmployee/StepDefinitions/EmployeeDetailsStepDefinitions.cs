using SpecFlowEmployee;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProjectEmployee.StepDefinitions
{
    [Binding]
    public class EmployeeDetailsStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private Employee employee = new Employee();
        private List<Employee> employees;

        public EmployeeDetailsStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            
        }

        [Given(@"the Department is ""([^""]*)""")]
        public void GivenTheDepartmentIs(string department)
        {
           employee.Department = department;
        }
        [Given(@"the following employees are present in the table")]
        public void GivenTheFollowingEmployeesArePresentInTheTable(Table table)
        {
            employees = (List<Employee>)table.CreateSet<Employee>();
        }


        [When(@"Department is present in the table")]
        public void WhenDepartmentIsPresentInTheTable()
        {
            Assert.Equal("Testing",employee.Department);
        }
        [When(@"I apply SpecFlow\.Assit")]
        public void WhenIApplySpecFlow_Assit()
        {
            //throw new PendingStepException();
        }

        [Then(@"the following Details are retrieved")]
        public void ThenTheFollowingDetailsAreRetrieved(Table table)
        {
            employees = (List<Employee>)table.CreateSet<Employee>();
        }
        [Then(@"the following Details are shown")]
        public void ThenTheFollowingDetailsAreShown(Table table)
        {
           table.CompareToSet(employees);
        }

    }
}
