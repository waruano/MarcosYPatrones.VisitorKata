using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.VisitorKata
{
    public class Marauder : IArmoredUnit
    {
        public int Health { get; set; }
        public Marauder()
        {
            Health = 125;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitArmored(this);
        }
    }
}
