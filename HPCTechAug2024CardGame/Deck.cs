using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTechAug2024CardGame;

public class Deck
{
    // list of cards
    public List<card> Cards { get; set; } = new List<card>();
    public int totalCards { get; set; }
    public int cardsRemaining { get; set; }

    public Deck()
    {
        try
        {
            // we need to create the cards in the deck
            List<string> suits = new List<string> { "♦", "♣", "♠", "♥" };
            List<string> ranks = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<int> values = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            // Iiterable
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    card myCardToAdd = new card(suit, rank, values[ranks.IndexOf(rank)]);
                    Cards.Add(myCardToAdd);
                    cardsRemaining++;
                }
            }
            totalCards = cardsRemaining;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public card DealRandomCard()
    {
        Random rnd = new Random();
        int cardToDealIndex = rnd.Next(cardsRemaining);
        card cardToDeal = Cards[cardToDealIndex];
        Cards.Remove(cardToDeal);
        cardsRemaining--;
        return cardToDeal;
    }

    public List<card> DealCards(int howManyCards)
    {
        if (howManyCards < 1)
        {
            // raise an error, handle this someway, etc.
            Console.WriteLine("Please enter a valid number of cards.");
            return new List<card>();
        }
        List<card> cardsToDeal = new List<card>();
        for (int i = 0; i < howManyCards; i++)
        {
            cardsToDeal.Add(DealRandomCard());
        }
        return cardsToDeal;

    }

    // do we really need this?
    public void Shuffle()
    {
        
    }
}
