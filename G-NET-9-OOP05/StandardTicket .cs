using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP05
{
    internal class StandardTicket: Ticket

    {
        string SeatNumber;

        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        public override string Print()
        {
            return   $", Standard Ticket: Seat Number: {SeatNumber}";
        }
    }
}
