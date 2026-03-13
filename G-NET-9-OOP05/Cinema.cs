using G_NET_9_OOP05;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_9_OOP05
{
    public class Cinema
    {
        private List<IPrintable> _tickets;

        public Cinema()
        {
            _tickets = new List<IPrintable>();
        }

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
        }

        public void Close()
        {
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets ---");
            foreach (var ticket in _tickets)
            {
                Console.WriteLine(ticket.Print());
            }
        }



    }
}

