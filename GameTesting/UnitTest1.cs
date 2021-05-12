using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouletteGame;
using System;

namespace GameTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogicTestOne()
        {
            Logic logic = new Logic();
            logic.Load();
            logic.Spin();
            bool found = false;
            int position = 1;
            found = logic.Fire(position);
            while (!found)
            {
                position++;
                found = logic.Fire(position);
            }
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void LogicTestTwo()
        {
            Logic logic = new Logic();
            logic.Load();
            Assert.AreEqual(logic.Fire(1), true);
        }
    }
}
