using System;
using NUnit.Framework;

namespace OngoingGame {
    public class PlayerTests {
        Player sut = new Player("test");
        [TestCase]
        public void GivenNewPlayer_WhenGetAttack_Then10() {
            Assert.AreEqual(5, sut.Attack);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetDefense_Then10() {
            Assert.AreEqual(5, sut.Defense);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetHealth_Then200() {
            Assert.AreEqual(200, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayerTest_WhenGetName_ThenWyatt() {
            Assert.AreEqual("test", sut.Name);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetLevel_Then1() {
            Assert.AreEqual(1, sut.Level);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetExp_Then0() {
            Assert.AreEqual(0, sut.Exp);
        }
    }
}