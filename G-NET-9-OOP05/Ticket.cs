using G_NET_9_OOP05;

public abstract class Ticket : IPrintable, IBookable
{
    protected static int _nextTicketId = 1;
    public int TicketId { get; protected set; }
    public string MovieName { get; set; }
    public decimal Price { get; protected set; }
    public bool IsBooked { get; protected set; }

    public Ticket(string movieName, decimal price)
    {
        TicketId = _nextTicketId++;
        MovieName = movieName;
        Price = price;
        IsBooked = false;
    }

    public bool Book()
    {
        if (IsBooked) return false;
        IsBooked = true;
        return true;
    }

    public bool Cancel()
    {
        if (!IsBooked) return false;
        IsBooked = false;
        return true;
    }

    public abstract string Print();

    protected string GetBookingStatus()
    {
        return IsBooked ? "Yes" : "No";
    }

    protected string FormatPrice(decimal value)
    {
        // Format to show decimal only if needed, matching the image example
        return value.ToString("G29");
    }
}