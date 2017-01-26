using NUnit.Framework;
using Santase.Cards;
using System;

namespace Santase.Tests.DeckTests
{
    [TestFixture]
    public class GetNextCard_Should
    {
        private Deck deck;

        [SetUp]
        public void DeckInitialization()
        {
            deck = new Deck();
        }

        [Test]
        public void ThrowArgumentException_WhenDeckIsEmpty()
        {
            Card card = deck.GetNextCard();

            Assert.Throws(typeof(ArgumentException), () =>
            {
                for (int i = 0; i < 30; i++)
                {
                    card = deck.GetNextCard();
                }
            });
        }
    }
}
