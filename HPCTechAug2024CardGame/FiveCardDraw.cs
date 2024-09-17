using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HPCTechAug2024CardGame;

public class FiveCardDraw
{
    // Check for Aces.  static
    public static bool CheckForAces(List<card> cards)
    {
        // query syntax
        var results = from card in cards
                      where card.rank == "A"
                      select card;

        return results.Count() > 0;

        //return cards.Any(card => card.rank == "A");

        //return cards.Select(card => card.rank).Contains("A");

        //return (from card in cards
        //       where card.rank == "A"
        //       select card).Any();
    }


    // Check for Pair
    public static bool CheckForPair(List<card> cards)
    {
        // count ranks by grouping 
        var results = cards.GroupBy(card => card.value);

        foreach (var group in results)
        {
            if (group.Count() == 2)
            {
                return true;
            }
        }

        return false;

        //var group = cards.GroupBy(card => card.value);
        //return group.Any(group => group.Count() == 2);


        //return (from card in cards
        //        group card by card.rank into g
        //        select g.Count() == 2).Any();
    }

    // check for three of a kind
    public static bool CheckForTrips(List<card> cards)
    {
        return (from card in cards
                group card by card.rank into g
                select g.Count() == 3).Any();
    }

    // full house
    public static bool CheckForFullHouse(List<card> cards)
    {
        return CheckForPair(cards) && CheckForTrips(cards);
    }

    // flush

    // straight

    // straight flush

    // four of a kind
}
