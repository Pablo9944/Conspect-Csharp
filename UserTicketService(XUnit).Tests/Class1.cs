using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService_XUnit_.Tests
{
    public class Class1
    {
        [Fact] // означает что тестовый метод
        public void TestVoid ()
        {
            Assert.True(100 == 100);
        }
       
    }
}
