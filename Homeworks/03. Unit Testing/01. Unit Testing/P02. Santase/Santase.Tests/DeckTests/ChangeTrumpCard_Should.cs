using NUnit.Framework;
using Santase.Cards;

namespace Santase.Tests.DeckTests
{
    [TestFixture]
    public class ChangeTrumpCard_Should
    {
        private Deck deck;

        [SetUp]
        public void DeckInitialization()
        {
            deck = new Deck();
        }

        [Test]
        public void ReturnTheNewTrumpCard()
        {
            Card card = new Card(CardSuit.Heart, CardType.King);
            deck.ChangeTrumpCard(card);

            Assert.AreEqual(card, deck.GetTrumpCard);
        }

    }
}
