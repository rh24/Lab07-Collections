﻿using System;
using Lab06_Collections.Classes;
using System.Collections.Generic;

namespace Lab06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Card card2 = new Card(CardSuits.Hearts, CardValues.Three);
            Card card3 = new Card(CardSuits.Spades, CardValues.Jack);
            Card card4 = new Card(CardSuits.Diamonds, CardValues.Ten);
            Card card5 = new Card(CardSuits.Clubs, CardValues.Two);
            Card card6 = new Card(CardSuits.Diamonds, CardValues.Ace);
            Card card7 = new Card(CardSuits.Diamonds, CardValues.Queen);
            Card card8 = new Card(CardSuits.Diamonds, CardValues.King);


            List<Card> cards = new List<Card> { card2, card3, card4, card5, card6, card7, card8 };

            //Console.WriteLine($"Suit: {card2.Suit}, Value: {card2.Value}");

            Deck<Card> deckOfCards = new Deck<Card>();

            foreach (var card in cards)
            {
                //Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
                deckOfCards.AddToDeck(card);
            }

            //deckOfCards.RemoveFromDeck(card3); // Removing Jack of Spades

            foreach (var cardInDeck in deckOfCards)
            {
                if (cardInDeck != null) Console.WriteLine($"{cardInDeck.Value.ToString()} of {cardInDeck.Suit.ToString()}");
            }


            // test return same suit
            var cardsOfSameSuit = deckOfCards.ReturnSuit(card8);

            foreach (var card in cardsOfSameSuit)
            {
                if (card != null) Console.WriteLine($"{card?.Value.ToString()} of {card?.Suit.ToString()}");
            }
        }
    }
}
