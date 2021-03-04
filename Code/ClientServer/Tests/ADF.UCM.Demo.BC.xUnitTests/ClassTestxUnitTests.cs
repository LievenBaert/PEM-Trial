using System;
using Xunit;
using Xunit.Categories;

namespace ADF.UCM.Demo.BC.xUnitTests
{
    public class ClassTestxUnitTests
    {
        [Fact(DisplayName = "xUnit: HelloWorldReturnNotEmpty")]
        [Trait("TestCategory", "UnitTest")]
        [Trait("Ref", "xUnit: Ref-123")]
        public void ClassTestHelloWorldReturnNotEmptyXUnitTest()
        {
            var target = new ClassTest();
            var actual = target.HelloWorld();
            Assert.Contains("Hello users", actual, StringComparison.OrdinalIgnoreCase);
        }

        [Fact(DisplayName = "xUnit: YsbGZMJBQ3Ca1ROmwG7D0uZFpbVFabfKJJgfCsY99YUw0GE1WroK7aHt3B6Re0U87wKBPVAHoEa9ArNy1kUXuzTvFLCz8uNkJYZOsZE8y42fQJHaSwAq6ohj86epPcXqQESGnpaHka7qfFSZHRaOcrdDxGxS6txE5204e5hFuidVflsZ1HNFI14SVGkSkpVGx1hGjrz3Y53OojwTh2w80Im5OofbaIPoM3Giv5rAwLQhlgszBsNXcDiH5hlStDm")]
        [Trait("TestCategory", "UnitTest")]
        public void ClassTestHelloWorldReturnNotEmptyXUnitTestLongTestName()
        {
            var target = new ClassTest();
            var actual = target.HelloWorld();
            Assert.Contains("Hello users", actual, StringComparison.OrdinalIgnoreCase);
        }

        [Fact(DisplayName = "xUnit: GetCustomersReturnNotEmpty")]
        [Category("UnitTest")]
        [Feature("myCustomerFeature")]
        public void ClassTestGetCustomersReturnNotEmptyXUnitTest()
        {
            var target = new ClassTest();
            var actual = target.GetCustomers();
            Assert.True(actual.Count == 0, "Customer list is not empty");
        }
    }
}
