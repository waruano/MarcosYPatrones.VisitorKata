﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.VisitorKata
{
    public class TankBullet : IVisitor
    {
        public void VisitLight(ILightUnit unit)
        {
            unit.Health -= 21;
        }

        public void VisitArmored(IArmoredUnit unit)
        {
            unit.Health -= 32;
        }
    }
}
