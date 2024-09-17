using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTechAug2024CardGame;

public class card
{
    // alt + numpad 3 or 4 or 5 or 6
    // ♠
    public string suit { get; set; }
    public string rank { get; set; }
    public int value { get; set; }

    /// <summary>
    /// This will create a new card
    /// </summary>
    /// <param name="suit">♦, ♣, ♠, ♥</param>
    /// <param name="rank">2, 3, 4... 10, J, Q, K, A</param>
    /// <param name="value">2, 3, 4... 10, 11, 12, 13, 14</param>
    public card(string suit, string rank, int value)
    {
        this.suit = suit;
        this.rank = rank;
        this.value = value;
    }

    public override string? ToString()
    {
        return $"{rank}{suit} ";
    }
}
