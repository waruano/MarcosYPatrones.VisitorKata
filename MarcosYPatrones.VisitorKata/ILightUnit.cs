using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.VisitorKata
{
    public interface ILightUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }
}
