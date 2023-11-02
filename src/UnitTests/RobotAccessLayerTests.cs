using NUnit.Framework;
using RobotAccess;

namespace UnitTests
{
    public class RobotAccessLayerTests
    {
        [Test]
        public void ShouldCreateClass()
        {
            // Arrange
            // Act
            var subject = new RobotAccessLayer();

            // Assert
            Assert.IsNotNull(subject);
        }

        [Test]
        public void ShouldIntroduceSelf()
        {
            // Arrange
            var sutIdentifier = "HAL 9000";
            var subject = new RobotAccessLayer();
            subject.Identifier = sutIdentifier;

            // Act
            var result = subject.IntroduceSelf();

            // Assert
            Assert.That(result, Contains.Substring(sutIdentifier));
        }
    }
}
