using Calculate_Volume_of_a_room;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoomCalculations.UnitTests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void AreaMethodGeneratesExpectedValue()
        {
            Room room = new Room(12, 8, 3);

            double result = room.Area();

            Assert.AreEqual(96, result);
        }
        [TestMethod]
        public void PaintNeededMethodGeneratesExpectedValue()
        {
            Room room = new Room(12, 8, 3);

            double result = room.PaintNeeded();

            Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void VolumeMethodGeneratesExpectedValue()
        {
            Room room = new Room(12, 8, 3);

            double result = room.Volume();

            Assert.AreEqual(288, result);
        }
    }

}
