using System;
using NUnit.Framework;

namespace OngoingGame {
    [TestFixture]
    public class PlayerTests {
        Player sut;

        [SetUp]
        public void Init() {
            sut = new Player("test");
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetAttack_Then5() {
            Assert.AreEqual(5, sut.Attack);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetAttack10_Then10() {
            sut.Attack = 10;
            Assert.AreEqual(10, sut.Attack);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetDefense_Then5() {
            Assert.AreEqual(5, sut.Defense);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetDefense10_Then10() {
            sut.Defense = 10;
            Assert.AreEqual(10, sut.Defense);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetHealth_Then250() {
            Assert.AreEqual(250, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetHealth500_Then500() {
            sut.Health = 500;
            Assert.AreEqual(500, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetHealthGreaterThan9999_Then9999() {
            sut.Health = 10000;
            Assert.AreEqual(9999, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetHealthNegative_ThenNegative1() {
            sut.Health = -1;
            Assert.AreEqual(0, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayerTest_WhenGetName_ThenTest() {
            Assert.AreEqual("test", sut.Name);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetLevel_Then1() {
            Assert.AreEqual(1, sut.Level);
        }

        [TestCase]
        public void GivenNewPlayer_WhenLevelUp_Then2() {
            sut.Level++;
            Assert.AreEqual(2, sut.Level);
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetExp_Then0() {
            Assert.AreEqual(0, sut.Exp);
        }
    }
}