/* 1. Understand the requirements
      - Convert numerals from Arabian to Roman and vice versa.
      - Roman numbers:
			I = 1,
			V = 5,
			X = 10,
			L = 50,
			C = 100,
			D = 500,
			M = 1000.
	  - Letters are repeated maximum 3 times to represent a higher number (I, II, III).
	  - I can be before V or X to substract the value (IV = 4, IX = 9).
      - Only natural numbers are used (1, 2, 3, ...).
      - The highest number that can be written with Roman numerals is the 3999 (MMMCMXCIX).
   2. Create a light way plan (test ideas)
      - Test that numbers are between 1 and 3999.
      - Test that numbers are integers.
      - That that a letter isn't used more than 3 times in a row.
   3. Set up the infrastructure
      + MonoDevelop
      + C#
      + GTK#
      + GIT 
      - unit test framework
   4. Check the project guidelines and team rules
      - TODO
   5. Practice inner TDD cycle
      - write the next test
      - write production code
      - refactoring
   6. Run code analysis and write the missing tests
   7. Separate the different test levels
   8. Do the administratiion and upload (Jira, Git, CI...)
*/

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Converter converter = new Converter();
        UInt32 arabian;
        string roman;
        
        for (arabian = 1U; arabian <= 100U; arabian++)
        {
            roman = converter.convert_arabian_to_roman(arabian);
            Console.WriteLine(arabian + " = " + roman);
        }
    }
}
