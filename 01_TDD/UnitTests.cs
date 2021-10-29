using System;

public class UnitTests
{
    static void unit_tests()
    {
        Converter converter = new Converter();
        
        UInt32 test_arabian;
        string test_roman;
        test_roman = "IV";
        test_arabian = converter.convert_roman_to_arabian(test_roman);
        if (test_arabian == 1)
        {
            Console.WriteLine("OK: " +  test_arabian + " == 1");
        }
        else
        {
            Console.WriteLine("Not OK: " + test_arabian + " != 1");
        }
    }
    
    public static void Main(string[] args)
    {
        unit_tests();
    }
}