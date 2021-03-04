using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADF.UCM.Demo.BC.Tests
{
    /// <summary>
    ///This is a test class for ClassTestTest and is intended
    ///to contain all ClassTestTest Unit Tests
    ///</summary>
    ///

    // see https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting?view=mstest-net-1.3.2
    [TestClass()]
    public class ClassTestMsTests
    {
        private TestContext _testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for HelloWorld
        ///</summary>
        [TestMethod("MsTest: HelloWorldReturnNotEmpty")]
        [TestCategory("UnitTest")]
        [TestProperty("Ref", "MsTest: Ref-123")]
        public void ClassTestHelloWorldReturnNotEmptyMsTestTest()
        {
            ClassTest target = new ClassTest();
            string actual = target.HelloWorld();
            Assert.IsTrue(!string.IsNullOrEmpty(actual), "Empty string returned");
        }

        [TestMethod("MsTest: YsbGZMJBQ3Ca1ROmwG7D0uZFpbVFabfKJJgfCsY99YUw0GE1WroK7aHt3B6Re0U87wKBPVAHoEa9ArNy1kUXuzTvFLCz8uNkJYZOsZE8y42fQJHaSwAq6ohj86epPcXqQESGnpaHka7qfFSZHRaOcrdDxGxS6txE5204e5hFuidVflsZ1HNFI14SVGkSkpVGx1hGjrz3Y53OojwTh2w80Im5OofbaIPoM3Giv5rAwLQhlgszBsNXcDiH5hlStDm")]
        [TestCategory("UnitTest")]
        public void ClassTestHelloWorldReturnNotEmptyMsTestTestLongTestName()
        {
            ClassTest target = new ClassTest();
            string actual = target.HelloWorld();
            Assert.IsTrue(!string.IsNullOrEmpty(actual), "Empty string returned");
        }
    }
}
