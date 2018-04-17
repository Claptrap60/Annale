using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  class Program
  {
    /*
     * CORRECTION TP C#1: Console Mode and Loops
     */

    /// <summary>
    /// Ex 0, Hello Worlds
    /// </summary>
    static void HelloWorlds(int n)
    {
      while (n-- > 0)
      {
        Console.WriteLine("Hello World!");
      }
    }

    /// <summary>
    /// Ex 1, Echo
    /// </summary>
    static void Echo()
    {
      string s = Console.ReadLine();
      Console.WriteLine(s);
    }

    /// <summary>
    /// Ex 2, Print Reverse
    /// </summary>
    static void PrintRev(string s, int i)
    {
      if (i < s.Length)
      {
        PrintRev(s, i + 1);
        Console.Write(s[i]);
      }
    }

    static void Reverse()
    {
      string s = Console.ReadLine();
      PrintRev(s, 0);
      Console.Write("\n");
    }

    /// <summary>
    /// Ex 3, Love ACDC
    /// </summary>
    static void LoveAcdc()
    {
      Console.Title = "Love ACDC";
      Console.BackgroundColor = ConsoleColor.Magenta;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  * * *   * * *  \n* *   * * *   * *\n*       *       *\n* *  <3 ACDC  * *\n  * *       * *  \n    * *   * *    \n      * * *      \n        *        \n"); // True folks do it in one line
      Console.ResetColor();
    }

    /// <summary>
    /// Ex 4 MCQ
    /// </summary>
    static void MCQ(string question, string rep1, string rep2, string rep3, string rep4, int rep)
    {
      Console.WriteLine(question);
      Console.WriteLine("1) " + rep1);
      Console.WriteLine("2) " + rep2);
      Console.WriteLine("3) " + rep3);
      Console.WriteLine("4) " + rep4);
      try
      {
        int rep_u = Convert.ToInt32(Console.ReadLine());
        if (rep_u == rep)
          Console.WriteLine("Good job bro!");
        else if (rep_u > 0 && rep_u < 5)
          Console.WriteLine("You lose... The answer was " + rep + ".");
        else
          Console.WriteLine("So counting is too hard, n00b...");
      }
      catch
      {
        Console.WriteLine("So counting is too hard, n00b...");
      }
    }

    // Example for MCQ exercise
    static void TestMCQ()
    {
      MCQ("Stop. Who would pass this practical work session must answer me these questions three, ere the good grade he see.",
          "Ask me the questions, ACDC. I am not afraid.",
          "U wot m8?",
          "Well, technically there are more than 3 questions to answer.",
          "Ni",
          1);
      Console.Clear();
      MCQ("What... is your name?",
          "Yet another SUP",
          "XxX_hEnRy_XxX",
          "Pedro Miranda",
          "Ni",
          1);
      Console.Clear();
      MCQ("What... is your quest?",
          "To seek for the Holy Grade",
          "Noscope the cheeky printer",
          "Every student must attend to the enterprise education course...",
          "Ni",
          1);
      Console.Clear();
      MCQ("What are all the flags of find(1)?",
          "Doesn't matter, just try 'find -D'",
          "Does it have to be POSIX compliant?",
          "CHEATERS WERE DETECTED",
          "Ni Ni Ni NI",
          1);
    }

    /// <summary>
    /// Ex 5, Best Years
    /// </summary>
    static void BestYears()
    {
      int i = 1989;
      while (i <= 2022)
      {
        Console.Write(i + " : ");
        if (i % 2 == 0)
        {
          if (i == 2020)
            Console.Write("Best Year\n");
          else if (i == 2022)
            Console.Write("Bad Year\n");
          else
            Console.Write("Good Year\n");

        }
        else
          Console.Write("Bad Year\n");
        ++i;
      }
    }

    /// <summary>
    /// Ex 6, Morse
    /// </summary>
    static void Morse(string s, int i = 0)
    {
      if (i < s.Length)
      {
        if (s[i] == '.')
          Console.Beep(900, 150);
        else if (s[i] == '_')
          Console.Beep(900, 450);
        else
          System.Threading.Thread.Sleep(450);
        Morse(s, i + 1);
      }
    }

    /// <summary>
    /// Ex 7, LightHouse
    /// </summary>
    static void LightHouse(int n)
    {
      Console.Write("  /^\\\n  |#|\n");
      while (n-- != 0)
        Console.Write(" |===|\n  |0|\n  | |\n");
      Console.Write(" =====\n_||_||_\n-------\n");
    }

    static void Main(string[] args)
    {
      HelloWorlds(3);
      Echo();
      Reverse();
      LoveAcdc();
      TestMCQ();
      BestYears();
      Morse(".___ .____. ._ .. __ .  __ . ...  ._ _._. _.. _._.");
      LightHouse(3);
      Console.ReadLine();
    }
  }
}
