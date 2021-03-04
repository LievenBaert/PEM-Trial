using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;
using Microsoft.Data.Schema.UnitTesting.Conditions;

namespace AUT_Database_Test
{
  [TestClass()]
  public class AUT_Database_Tests : DatabaseTestClass
  {

    public AUT_Database_Tests()
    {
      InitializeComponent();
    }

    [TestInitialize()]
    public void TestInitialize()
    {
      base.InitializeTest();
    }
    [TestCleanup()]
    public void TestCleanup()
    {
      base.CleanupTest();
    }

    [TestMethod()]
    public void AUTDatabaseTests()
    {
      DatabaseTestActions testActions = this.AUTDatabaseTestsData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      // Execute the test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
      ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      // Execute the post-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
      ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
    }
    [TestMethod()]
    public void dbo_USP_WY_AUTUSR_DELETETest()
    {
      DatabaseTestActions testActions = this.dbo_USP_WY_AUTUSR_DELETETestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      // Execute the test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
      ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      // Execute the post-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
      ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
    }

    [TestMethod()]
    public void dbo_USP_WY_AUTUSR_INSERTTest()
    {
      DatabaseTestActions testActions = this.dbo_USP_WY_AUTUSR_INSERTTestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      // Execute the test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
      ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      // Execute the post-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
      ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
    }

    [TestMethod()]
    public void dbo_USP_WY_AUTUSR_UPDATETest()
    {
      DatabaseTestActions testActions = this.dbo_USP_WY_AUTUSR_UPDATETestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      // Execute the test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
      ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      // Execute the post-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
      ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
    }

    [TestMethod()]
    public void dbo_USP_getUsersTest()
    {
      DatabaseTestActions testActions = this.dbo_USP_getUsersTestData;
      // Execute the pre-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
      ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
      // Execute the test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
      ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
      // Execute the post-test script
      // 
      System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
      ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
    }


    #region Designer support code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction AUTDatabaseTests_TestAction;
      Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction AUTDatabaseTests_PretestAction;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AUT_Database_Tests));
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_USP_WY_AUTUSR_DELETETest_TestAction;
      Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_USP_WY_AUTUSR_INSERTTest_TestAction;
      Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_USP_WY_AUTUSR_UPDATETest_TestAction;
      Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_USP_getUsersTest_TestAction;
      Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
      Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_USP_getUsersTest_PretestAction;
      this.AUTDatabaseTestsData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
      this.dbo_USP_WY_AUTUSR_DELETETestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
      this.dbo_USP_WY_AUTUSR_INSERTTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
      this.dbo_USP_WY_AUTUSR_UPDATETestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
      this.dbo_USP_getUsersTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
      AUTDatabaseTests_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      inconclusiveCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition();
      AUTDatabaseTests_PretestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      dbo_USP_WY_AUTUSR_DELETETest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      inconclusiveCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition();
      dbo_USP_WY_AUTUSR_INSERTTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      inconclusiveCondition3 = new Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition();
      dbo_USP_WY_AUTUSR_UPDATETest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      inconclusiveCondition4 = new Microsoft.Data.Schema.UnitTesting.Conditions.InconclusiveCondition();
      dbo_USP_getUsersTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      rowCountCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
      dbo_USP_getUsersTest_PretestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
      // 
      // AUTDatabaseTestsData
      // 
      this.AUTDatabaseTestsData.PosttestAction = null;
      this.AUTDatabaseTestsData.PretestAction = AUTDatabaseTests_PretestAction;
      this.AUTDatabaseTestsData.TestAction = AUTDatabaseTests_TestAction;
      // 
      // AUTDatabaseTests_TestAction
      // 
      AUTDatabaseTests_TestAction.Conditions.Add(inconclusiveCondition1);
      resources.ApplyResources(AUTDatabaseTests_TestAction, "AUTDatabaseTests_TestAction");
      // 
      // inconclusiveCondition1
      // 
      inconclusiveCondition1.Enabled = true;
      inconclusiveCondition1.Name = "inconclusiveCondition1";
      // 
      // AUTDatabaseTests_PretestAction
      // 
      resources.ApplyResources(AUTDatabaseTests_PretestAction, "AUTDatabaseTests_PretestAction");
      // 
      // dbo_USP_WY_AUTUSR_DELETETestData
      // 
      this.dbo_USP_WY_AUTUSR_DELETETestData.PosttestAction = null;
      this.dbo_USP_WY_AUTUSR_DELETETestData.PretestAction = null;
      this.dbo_USP_WY_AUTUSR_DELETETestData.TestAction = dbo_USP_WY_AUTUSR_DELETETest_TestAction;
      // 
      // dbo_USP_WY_AUTUSR_DELETETest_TestAction
      // 
      dbo_USP_WY_AUTUSR_DELETETest_TestAction.Conditions.Add(inconclusiveCondition2);
      resources.ApplyResources(dbo_USP_WY_AUTUSR_DELETETest_TestAction, "dbo_USP_WY_AUTUSR_DELETETest_TestAction");
      // 
      // inconclusiveCondition2
      // 
      inconclusiveCondition2.Enabled = true;
      inconclusiveCondition2.Name = "inconclusiveCondition2";
      // 
      // dbo_USP_WY_AUTUSR_INSERTTestData
      // 
      this.dbo_USP_WY_AUTUSR_INSERTTestData.PosttestAction = null;
      this.dbo_USP_WY_AUTUSR_INSERTTestData.PretestAction = null;
      this.dbo_USP_WY_AUTUSR_INSERTTestData.TestAction = dbo_USP_WY_AUTUSR_INSERTTest_TestAction;
      // 
      // dbo_USP_WY_AUTUSR_INSERTTest_TestAction
      // 
      dbo_USP_WY_AUTUSR_INSERTTest_TestAction.Conditions.Add(inconclusiveCondition3);
      resources.ApplyResources(dbo_USP_WY_AUTUSR_INSERTTest_TestAction, "dbo_USP_WY_AUTUSR_INSERTTest_TestAction");
      // 
      // inconclusiveCondition3
      // 
      inconclusiveCondition3.Enabled = true;
      inconclusiveCondition3.Name = "inconclusiveCondition3";
      // 
      // dbo_USP_WY_AUTUSR_UPDATETestData
      // 
      this.dbo_USP_WY_AUTUSR_UPDATETestData.PosttestAction = null;
      this.dbo_USP_WY_AUTUSR_UPDATETestData.PretestAction = null;
      this.dbo_USP_WY_AUTUSR_UPDATETestData.TestAction = dbo_USP_WY_AUTUSR_UPDATETest_TestAction;
      // 
      // dbo_USP_WY_AUTUSR_UPDATETest_TestAction
      // 
      dbo_USP_WY_AUTUSR_UPDATETest_TestAction.Conditions.Add(inconclusiveCondition4);
      resources.ApplyResources(dbo_USP_WY_AUTUSR_UPDATETest_TestAction, "dbo_USP_WY_AUTUSR_UPDATETest_TestAction");
      // 
      // inconclusiveCondition4
      // 
      inconclusiveCondition4.Enabled = true;
      inconclusiveCondition4.Name = "inconclusiveCondition4";
      // 
      // dbo_USP_getUsersTestData
      // 
      this.dbo_USP_getUsersTestData.PosttestAction = null;
      this.dbo_USP_getUsersTestData.PretestAction = dbo_USP_getUsersTest_PretestAction;
      this.dbo_USP_getUsersTestData.TestAction = dbo_USP_getUsersTest_TestAction;
      // 
      // dbo_USP_getUsersTest_TestAction
      // 
      dbo_USP_getUsersTest_TestAction.Conditions.Add(rowCountCondition1);
      resources.ApplyResources(dbo_USP_getUsersTest_TestAction, "dbo_USP_getUsersTest_TestAction");
      // 
      // rowCountCondition1
      // 
      rowCountCondition1.Enabled = true;
      rowCountCondition1.Name = "rowCountCondition1";
      rowCountCondition1.ResultSet = 1;
      rowCountCondition1.RowCount = 3;
      // 
      // dbo_USP_getUsersTest_PretestAction
      // 
      resources.ApplyResources(dbo_USP_getUsersTest_PretestAction, "dbo_USP_getUsersTest_PretestAction");
    }

    #endregion


    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    #endregion

    private DatabaseTestActions AUTDatabaseTestsData;
    private DatabaseTestActions dbo_USP_WY_AUTUSR_DELETETestData;
    private DatabaseTestActions dbo_USP_WY_AUTUSR_INSERTTestData;
    private DatabaseTestActions dbo_USP_WY_AUTUSR_UPDATETestData;
    private DatabaseTestActions dbo_USP_getUsersTestData;
  }
}
