using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService_Moq_Tests
{
    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }
}
