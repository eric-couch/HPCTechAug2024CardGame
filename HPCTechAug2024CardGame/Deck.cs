using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTechAug2024CardGame;

public class Deck
{
    // list of cards
    public List<card> Cards { get; set; }
    public int totalCards { get; set; }
    public int cardsRemaining { get; set; }

    public Deck()
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
                Cards.Add(new card(suit, rank, values[rank.IndexOf(rank)]));
                cardsRemaining++;
            }
        }
        totalCards = cardsRemaining;
    }



    // do we really need this?
    public void Shuffle()
    {
        
    }
}
