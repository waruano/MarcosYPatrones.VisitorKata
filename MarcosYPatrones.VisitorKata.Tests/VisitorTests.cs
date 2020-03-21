using NUnit.Framework;

namespace MarcosYPatrones.VisitorKata.Tests
{
    [TestFixture]
    public class VisitorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _0_VisitLight()
        {
            IVisitor bullet = new TankBullet();
            ILightUnit light = new Marine();

            light.Accept(bullet);

            Assert.AreEqual(100 - 21, light.Health);
        }

        [Test]
        public void _1_VisitArmored()
        {
            IVisitor bullet = new TankBullet();
            IArmoredUnit armored = new Marauder();

            armored.Accept(bullet);

            Assert.AreEqual(125 - 32, armored.Health);
        }
    }
}