using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.VisitorKata
{
    public interface IVisitor
    {
        void VisitLight(ILightUnit unit);
        void VisitArmored(IArmoredUnit unit);
    }

}
