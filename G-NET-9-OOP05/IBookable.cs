using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP05
{
    public interface IBookable
    {
        bool IsBooked { get; }
        bool Book();
        bool Cancel();

    }
}
