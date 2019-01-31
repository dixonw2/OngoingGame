using System;
using NUnit.Framework;

namespace OngoingGame {
    public class PlayerTests {
        Player sut = new Player("test");
        [TestCase]
        public void GivenNewPlayer_WhenGetAttack_Then10() {
            Assert.AreEqual(10, sut.Attack);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetDefense_Then10() {
            Assert.AreEqual(10, sut.Defense);
        }
    }
}