using System;
using NUnit.Framework;

namespace OngoingGame {
    public class PlayerTests {
        [TestCase]
        public void GivenNewPlayer_WhenGetAttack_Then5() {
            Assert.AreEqual(5, new Player("sut").Attack);
        }
    }
}