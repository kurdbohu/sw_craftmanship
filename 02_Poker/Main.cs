using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        card_type[] my_cards = new card_type[]
        {
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_KING},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_10},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_JACK},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_ACE},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_QUEEN},
        };
        
        HandRank hand_rank = new HandRank();
        bool winner = hand_rank.has_royal_flush(my_cards);
        Console.WriteLine("Win = " + winner);
    }
}
