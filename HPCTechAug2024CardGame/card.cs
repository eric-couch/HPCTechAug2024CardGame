using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCTechAug2024CardGame;

public class card
{
    public string suit { get; set; }
    public string rank { get; set; }
    public int value { get; set; }

    public card(string suit, string rank, int value)
    {
        this.suit = suit;
        this.rank = rank;
        this.value = value;
    }


}
