using System;
using NUnit.Framework;

namespace ADF.UCM.Demo.BC.nUnitTests
{
    // see https://docs.nunit.org/articles/nunit/writing-tests/attributes/apartment.html
    //     http://hermit.no/how-to-change-visual-studio-test-explorer-testnaming-using-nunit/
    [TestFixture]
    public class ClassTestnUnitTests
    {
        [TestCase(TestName = "nUnit: HelloWorldReturnNotEmpty")]
        [Category("UnitTest")]
        [Property("Ref", "nUnit: Ref-123")]
        public void ClassTestHelloWorldReturnNotEmptyNUnitTest()
        {
            var target = new ClassTest();
            var actual = target.HelloWorld();
            Assert.That(actual, Does.Match(@"^Hello\susers\sof\s(?<AppName>[A-Za-z]*){1};"), "Wrong string returned"); //NUnit  
        }

        [TestCase(TestName = "nUnit: YsbGZMJBQ3Ca1ROmwG7D0uZFpbVFabfKJJgfCsY99YUw0GE1WroK7aHt3B6Re0U87wKBPVAHoEa9ArNy1kUXuzTvFLCz8uNkJYZOsZE8y42fQJHaSwAq6ohj86epPcXqQESGnpaHka7qfFSZHRaOcrdDxGxS6txE5204e5hFuidVflsZ1HNFI14SVGkSkpVGx1hGjrz3Y53OojwTh2w80Im5OofbaIPoM3Giv5rAwLQhlgszBsNXcDiH5hlStDm")]
        [Category("UnitTest")]
        public void ClassTestHelloWorldReturnNotEmptyNUnitTestLongTestName()
        {
            var target = new ClassTest();
            var actual = target.HelloWorld();
            Assert.That(actual, Does.Match(@"^Hello\susers\sof\s(?<AppName>[A-Za-z]*){1};"), "Wrong string returned"); //NUnit  
        }
    }
}
