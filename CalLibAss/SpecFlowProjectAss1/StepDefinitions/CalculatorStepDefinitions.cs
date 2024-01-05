using System;
using TechTalk.SpecFlow;
using CalLibAss;
namespace SpecFlowProjectAss1.StepDefinitions

{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenariocontext;
        private readonly CalculatorAss calculator;
        private int result;

        public CalculatorStepDefinitions(ScenarioContext scenariocontext)
        {
            this.scenariocontext = scenariocontext;
            this.calculator = new CalculatorAss();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.num1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.num2 = number;
        }

        [When("the two numbers are multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {

            result = calculator.Multiplication();
        }

        [When("the two numbers are subtract")]
        public void WhenTheTwoNumbersAreSubtract()
        {

            result = calculator.Subtraction();
        }

        [When("the two numbers are divide")]
        public void WhenTheTwoNumbersAreDivide()
        {

            result = calculator.Division();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {


            result.Should().Be(result);
        }


    }
}
