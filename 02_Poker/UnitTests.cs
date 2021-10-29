using System;

class UnitTests
{
    static bool test_royal_flush()
    {
        card_type[] my_cards = new card_type[]
        {
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_KING},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_10},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_JACK},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_ACE},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_QUEEN},
        };
        
        HandRank hand_rank = new HandRank();
        bool     success   = hand_rank.has_royal_flush(my_cards);
        
        return(success);
    }
    
    static void Main(string[] args)
    {
        bool success = true;
        success &= test_royal_flush();
        Console.WriteLine("Success = " + success);
    }
}
