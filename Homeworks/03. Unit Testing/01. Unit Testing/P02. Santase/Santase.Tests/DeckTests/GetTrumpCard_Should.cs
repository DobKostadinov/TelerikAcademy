using NUnit.Framework;
using Santase.Cards;

namespace Santase.Tests.DeckTests
{
    [TestFixture]
    public class GetTrumpCard_Should
    {
        private Deck deck;

        [SetUp]
        public void DeckInitialization()
        {
            deck = new Deck();
        }

        [Test]
        public void ReturnInstanceOfCard()
        {
            Card card = deck.GetTrumpCard;

            Assert.IsInstanceOf(typeof(Card), card);
        }
    }
}
