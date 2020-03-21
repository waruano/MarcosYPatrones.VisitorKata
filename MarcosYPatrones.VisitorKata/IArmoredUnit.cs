using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.VisitorKata
{
    public interface IArmoredUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }
}
