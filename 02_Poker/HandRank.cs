using System;

public enum CARD_COLOR
{
    CC_HEARTS,
    CC_DIAMONDS,
    CC_CLUBS,
    CC_SPADES
}

public enum CARD_VALUE
{
    CV_2,
    CV_3,
    CV_4,
    CV_5,
    CV_6,
    CV_7,
    CV_8,
    CV_9,
    CV_10,
    CV_JACK,
    CV_QUEEN,
    CV_KING,
    CV_ACE
}

public class card_type
{
    public CARD_COLOR color;
    public CARD_VALUE value;
}

public class HandRank
{
    public bool has_royal_flush(card_type[] cards)
    {
        bool has_it = true;
        card_type[] royal_flush_cards = new card_type[]
        {
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_ACE},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_KING},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_QUEEN},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_JACK},
            new card_type {color = CARD_COLOR.CC_SPADES, value = CARD_VALUE.CV_10}
        };
        
        foreach (card_type royal_flush_card in royal_flush_cards)
        {
            bool found = false;
            foreach (card_type card in cards)
            {
                if (card.color == royal_flush_card.color && 
                    card.value == royal_flush_card.value)
                {
                    Console.WriteLine("OK (" + card.color + ", " + card.value + ")");
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                has_it = false;
                break;
            }
        }
        
        return(has_it);
    }
}
