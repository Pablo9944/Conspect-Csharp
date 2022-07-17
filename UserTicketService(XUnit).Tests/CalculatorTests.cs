using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService_XUnit_.Tests
{
   public  class CalculatorTests
    {
        [Fact]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.Equal(10, calculator.Multiplication(5, 2));
        }

    }
}
