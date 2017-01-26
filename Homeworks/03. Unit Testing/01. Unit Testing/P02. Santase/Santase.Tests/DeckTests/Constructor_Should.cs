using NUnit.Framework;

namespace Santase.Tests.DeckTests
{
    [TestFixture]
    public class Constructor_Should
    {
        private const int AllCards = 24;
        private Deck deck;

        [SetUp]
        public void DeckInitialization()
        {
            deck = new Deck();
        }

        [Test]
        public void CreateNewDeck_WithTotalNumberOfCards()
        {
            Assert.AreEqual(AllCards, deck.CardsLeft);
        }

    }
}
