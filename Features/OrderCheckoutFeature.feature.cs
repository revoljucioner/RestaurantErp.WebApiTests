﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RestaurantErp.WebApiTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OrderCheckoutFeature")]
    public partial class OrderCheckoutFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "OrderCheckoutFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "OrderCheckoutFeature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ThreeProductsBy4Items_Checkout_BillIsCorrect")]
        public virtual void ThreeProductsBy4Items_Checkout_BillIsCorrect()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ThreeProductsBy4Items_Checkout_BillIsCorrect", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Index",
                            "Name",
                            "Price"});
                table1.AddRow(new string[] {
                            "0",
                            "Starter",
                            "4"});
                table1.AddRow(new string[] {
                            "1",
                            "Main",
                            "7"});
                table1.AddRow(new string[] {
                            "2",
                            "Drink",
                            "2.5"});
#line 4
 testRunner.Given("Create products as follow", ((string)(null)), table1, "Given ");
#line hidden
#line 9
 testRunner.When("Create order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProductIndex",
                            "Count"});
                table2.AddRow(new string[] {
                            "0",
                            "4"});
                table2.AddRow(new string[] {
                            "1",
                            "4"});
                table2.AddRow(new string[] {
                            "2",
                            "4"});
#line 10
 testRunner.And("Add items to order as follow", ((string)(null)), table2, "And ");
#line hidden
#line 15
 testRunner.And("Checkout order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Amount",
                            "Discount",
                            "AmountDiscounted",
                            "Service",
                            "Total"});
                table3.AddRow(new string[] {
                            "54",
                            "0",
                            "54",
                            "5.4",
                            "59.4"});
#line 16
 testRunner.Then("Bill is as follow", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SeveralItemsWithDiscountSeveralTooLate_Checkout_BillIsCorrect")]
        public virtual void SeveralItemsWithDiscountSeveralTooLate_Checkout_BillIsCorrect()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SeveralItemsWithDiscountSeveralTooLate_Checkout_BillIsCorrect", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Index",
                            "Name",
                            "Price"});
                table4.AddRow(new string[] {
                            "0",
                            "Starter",
                            "4"});
                table4.AddRow(new string[] {
                            "1",
                            "Main",
                            "7"});
                table4.AddRow(new string[] {
                            "2",
                            "Drink",
                            "2.5"});
#line 21
 testRunner.Given("Create products as follow", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProductIndex",
                            "StartTime",
                            "EndTime",
                            "DiscountValue"});
                table5.AddRow(new string[] {
                            "2",
                            "Now - 10 minutes",
                            "Now + 10 seconds",
                            "0.3"});
#line 26
 testRunner.And("Set discount by time as follow", ((string)(null)), table5, "And ");
#line hidden
#line 29
 testRunner.When("Create order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProductIndex",
                            "Count"});
                table6.AddRow(new string[] {
                            "0",
                            "1"});
                table6.AddRow(new string[] {
                            "1",
                            "2"});
                table6.AddRow(new string[] {
                            "2",
                            "2"});
#line 30
 testRunner.And("Add items to order as follow", ((string)(null)), table6, "And ");
#line hidden
#line 35
 testRunner.And("Wait \'11\' seconds after discount creation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProductIndex",
                            "Count"});
                table7.AddRow(new string[] {
                            "1",
                            "2"});
                table7.AddRow(new string[] {
                            "2",
                            "2"});
#line 36
 testRunner.And("Add items to order as follow", ((string)(null)), table7, "And ");
#line hidden
#line 40
 testRunner.And("Checkout order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Amount",
                            "Discount",
                            "AmountDiscounted",
                            "Service",
                            "Total"});
                table8.AddRow(new string[] {
                            "42",
                            "1.5",
                            "40.5",
                            "4.05",
                            "44.55"});
#line 41
 testRunner.Then("Bill is as follow", ((string)(null)), table8, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ThreeProductsBy4Items_CancellAllProductsBy1QtyAndCheckout_BillIsCorrect")]
        public virtual void ThreeProductsBy4Items_CancellAllProductsBy1QtyAndCheckout_BillIsCorrect()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ThreeProductsBy4Items_CancellAllProductsBy1QtyAndCheckout_BillIsCorrect", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Index",
                            "Name",
                            "Price"});
                table9.AddRow(new string[] {
                            "0",
                            "Starter",
                            "4"});
                table9.AddRow(new string[] {
                            "1",
                            "Main",
                            "7"});
                table9.AddRow(new string[] {
                            "2",
                            "Drink",
                            "2.5"});
#line 46
 testRunner.Given("Create products as follow", ((string)(null)), table9, "Given ");
#line hidden
#line 51
 testRunner.When("Create order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProductIndex",
                            "Count"});
                table10.AddRow(new string[] {
                            "0",
                            "4"});
                table10.AddRow(new string[] {
                            "1",
                            "4"});
                table10.AddRow(new string[] {
                            "2",
                            "4"});
#line 52
 testRunner.And("Add items to order as follow", ((string)(null)), table10, "And ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "ProductIndex",
                            "Count"});
                table11.AddRow(new string[] {
                            "0",
                            "1"});
                table11.AddRow(new string[] {
                            "1",
                            "1"});
                table11.AddRow(new string[] {
                            "2",
                            "1"});
#line 57
 testRunner.And("Cancel items as follow", ((string)(null)), table11, "And ");
#line hidden
#line 62
 testRunner.And("Checkout order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Amount",
                            "Discount",
                            "AmountDiscounted",
                            "Service",
                            "Total"});
                table12.AddRow(new string[] {
                            "40.5",
                            "0",
                            "40.5",
                            "4.05",
                            "44.55"});
#line 63
 testRunner.Then("Bill is as follow", ((string)(null)), table12, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion