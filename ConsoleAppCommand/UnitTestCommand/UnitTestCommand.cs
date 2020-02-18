using ConsoleAppCommand.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppCommand;

namespace UnitTestCommand
{
    [TestClass]
    public class UnitTestCommand
    {
        GameComponent fakeGameComponent;

        public UnitTestCommand()
        {
            fakeGameComponent = new GameComponent();
        }

        [TestMethod]
        public void TestCommandMoveUp()
        {
            // Arrange
            int originalLocationY = fakeGameComponent.Y;
            Command moveUp = new MoveUpCommand();
            int finalLocationY;
            // The amount the game object should move in one command
            int expectedMoveAmount = 1;

            // Act
            moveUp.Execute(fakeGameComponent);
            finalLocationY = fakeGameComponent.Y;

            // Assert
            Assert.AreEqual(finalLocationY, originalLocationY + expectedMoveAmount);
        }

        [TestMethod]
        public void TestCommandMoveDown()
        {
            // Arrange
            int originalLocationY = fakeGameComponent.Y;
            Command moveDown = new MoveDownCommand();
            int finalLocationY;
            // The amount the game object should move in one command
            int expectedMoveAmount = 1;

            // Act
            moveDown.Execute(fakeGameComponent);
            finalLocationY = fakeGameComponent.Y;

            // Assert
            Assert.AreEqual(finalLocationY, originalLocationY - expectedMoveAmount);
        }

        [TestMethod]
        public void TestCommandMoveRight()
        {
            // Arrange
            int originalLocationX = fakeGameComponent.X;
            Command moveRight = new MoveRightCommand();
            int finalLocationX;
            // The amount the game object should move in one command
            int expectedMoveAmount = 1;

            // Act
            moveRight.Execute(fakeGameComponent);
            finalLocationX = fakeGameComponent.X;

            // Assert
            Assert.AreEqual(finalLocationX, originalLocationX + expectedMoveAmount);
        }

        [TestMethod]
        public void TestCommandMoveLeft()
        {
            // Arrange
            int originalLocationX = fakeGameComponent.X;
            Command moveLeft = new MoveLeftCommand();
            int finalLocationX;
            // The amount the game object should move in one command
            int expectedMoveAmount = 1;

            // Act
            moveLeft.Execute(fakeGameComponent);
            finalLocationX = fakeGameComponent.X;

            // Assert
            Assert.AreEqual(finalLocationX, originalLocationX - expectedMoveAmount);
        }
    }
}
