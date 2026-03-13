using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP05
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; private set; }

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override string Print()
        {
            decimal afterTax = Price * 1.14M;
            return $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {FormatPrice(Price)} | After Tax: {FormatPrice(afterTax)} | Booked: {GetBookingStatus()}";
        }
    }

}
