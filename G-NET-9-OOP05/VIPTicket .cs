using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP05
{
    public class VIPTicket : Ticket, ICloneable
    {
        public bool HasLoungeAccess { get; private set; }
        public decimal Fee { get; private set; }

        public VIPTicket(string movieName, decimal price, bool hasLoungeAccess, decimal fee) : base(movieName, price)
        {
            HasLoungeAccess = hasLoungeAccess;
            Fee = fee;
        }

        public override string Print()
        {
            decimal afterTax = Price * 1.14M;
            return $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(HasLoungeAccess ? "Yes" : "No")} | Fee: {FormatPrice(Fee)} | Price: {FormatPrice(Price)} | After Tax: {FormatPrice(afterTax)} | Booked: {GetBookingStatus()}";
        }

        public object Clone()
        {
            VIPTicket clonedTicket = (VIPTicket)this.MemberwiseClone();
            clonedTicket.TicketId = Ticket._nextTicketId++;
            clonedTicket.IsBooked = false;
            return clonedTicket;
        }
    }
}
