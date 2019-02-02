using System;
using NUnit.Framework;

namespace OngoingGame {
    [TestFixture]
    public class PlayerTests {
        Player sut;

        [SetUp]
        public void Init() {
            sut = new Player("System Under Test");
        }

        [TestCase]
        public void GivenNewPlayer_WhenGetAttack_Then5() {
            Assert.AreEqual(10, sut.Attack);
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
        public void GivenNewPlayer_WhenSetMaxHealth500_Then500() {
            sut.MaxHealth = 500;
            Assert.AreEqual(500, sut.MaxHealth);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetMaxHealth500AndSetCurHealth9999_Then500() {
            sut.MaxHealth = 500;
            sut.Health = 9999;
            Assert.AreEqual(500, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetMaxHealthGreaterThan9999_Then9999() {
            sut.MaxHealth = 10000;
            Assert.AreEqual(9999, sut.MaxHealth);
        }

        [TestCase]
        public void GivenNewPlayer_WhenSetHealthNegative_Then0() {
            sut.Health = -1;
            Assert.AreEqual(0, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayer_WhenMinusEqualHealth5_Then245() {
            sut.Health -= 5;
            Assert.AreEqual(245, sut.Health);
        }

        [TestCase]
        public void GivenNewPlayerTest_WhenGetName_ThenSystemUnderTest() {
            Assert.AreEqual("System Under Test", sut.Name);
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

        [TestCase]
        public void GivenNewPlayer_WhenWinFightTestMob_ThenWin() {
            Assert.IsTrue(sut.WinFight(new TestMob(sut)));
        }
    }

    class TestMob : Hostile {
        private const string name = "Test Mob";
        public TestMob(Player player) : base(name, player) {
        }
    }

}