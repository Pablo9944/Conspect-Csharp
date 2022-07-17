using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTicketService_Moq_;

namespace UserTicketService_Moq_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }
}
