using HPCTechAug2024CardGame;

Console.OutputEncoding = System.Text.Encoding.Unicode;

// Five Card Draw
Deck myDeck = new Deck();

List<card> hand = myDeck.DealCards(5);

foreach (card card in hand)
{
    Console.Write(card);
}
Console.WriteLine();

Console.WriteLine($"Checking for Pair: {FiveCardDraw.CheckForPair(hand)}");
