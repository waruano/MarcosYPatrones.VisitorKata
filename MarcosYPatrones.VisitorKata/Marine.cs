using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.VisitorKata
{
    public class Marine : ILightUnit
    {
        public int Health { get; set; }
        public Marine()
        {
            this.Health = 100;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }
}
