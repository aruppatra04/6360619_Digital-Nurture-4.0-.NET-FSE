using NUnit.Framework;
using Moq;
using PlayersManagerLib;
using System;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> _mock;

        [OneTimeSetUp]
        public void Setup()
        {
            _mock = new Mock<IPlayerMapper>();
        }

        [Test]
        public void RegisterNewPlayer_WithValidName_ReturnsCorrectPlayer()
        {
            // Arrange
            _mock.Setup(m => m.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            // Act
            var player = Player.RegisterNewPlayer("Virat", _mock.Object);

            // Assert
            Assert.That(player, Is.Not.Null);
            Assert.That(player.Name, Is.EqualTo("Virat"));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));

            // Output
            TestContext.WriteLine($"Player created: {player.Name}, {player.Age}, {player.Country}, Matches: {player.NoOfMatches}");
        }

        [Test]
        public void RegisterNewPlayer_WithExistingName_ThrowsArgumentException()
        {
            // Arrange
            _mock.Setup(m => m.IsPlayerNameExistsInDb("Virat")).Returns(true);

            // Act + Assert
            var ex = Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("Virat", _mock.Object));
            Assert.That(ex.Message, Is.EqualTo("Player name already exists."));
            TestContext.WriteLine("Exception thrown as expected: " + ex.Message);
        }

        [Test]
        public void RegisterNewPlayer_WithEmptyName_ThrowsArgumentException()
        {
            // Act + Assert
            var ex = Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("", _mock.Object));
            Assert.That(ex.Message, Is.EqualTo("Player name can’t be empty."));
            TestContext.WriteLine("Exception thrown as expected: " + ex.Message);
        }
    }
}
