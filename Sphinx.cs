using System;
using System.Collections.Generic;


class Sphinx
{
  public static int thisThing = 0;
  static void Main()
  {
    Console.WriteLine("I AM SPHINX. ANSWER MY RIDDLES OR DIE");
    Console.WriteLine(Play());
    }

  static string Play()
  {
    bool isCorrect = true;
      while (isCorrect)   
      {
        if (thisThing <= 2)
        {
          Console.WriteLine(thisThing);  
          isCorrect = AskRiddle();
        }
        else 
        {
          isCorrect = false;
          return "AHHH... I've died. You win.";
        }
      }
      return "You lose.";
  }

  static bool AskRiddle()
  {
    string[] riddles = {"The more of them you take, the more you leave behind. What are they?", "What is more useful when it is broken?", "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "What runs around the whole yard without moving?", "What can you catch but never throw?"};
    string[] response = {"footsteps", "egg", "fire", "fence", "a cold"};
    Random rnd = new Random();
    int randomIndex = rnd.Next(0,5);
    Console.WriteLine(riddles[randomIndex]);
    string userAnswer = Console.ReadLine();
    if(userAnswer == response[randomIndex])
    {
      thisThing ++;
      return true;

    }
    else
    {
      return false;
    }
  }
}













    // if (userInput == thisThing["A1"] || userInput == thisThing["A2"])
    // {
    //   Console.WriteLine("You live... FOR NOW!");
      // Console.WriteLine(riddleTwo["Q"]);

      // string userInput2 = Console.ReadLine();

      // if (userInput2 == riddleTwo["A1"] || userInput2 == riddleTwo["A2"]) 
      // {
      //   Console.WriteLine("You live... FOR NOW!"); 
      //   Console.WriteLine(riddleThree["Q"]);

      //   string userInput3 = Console.ReadLine();

    //     if (userInput3 == riddleThree["A1"] || userInput3 == riddleThree["A2"]) 
    //     {
    //       Console.WriteLine("You live... FOR NOW!"); 
    //       Console.WriteLine(riddleFour["Q"]);
                  
    //       string userInput4 = Console.ReadLine();

    //       if (userInput4 == riddleFour["A1"] || userInput4 == riddleFour["A2"]) 
    //       {
    //         Console.WriteLine("You live... FOR NOW!"); 
    //         Console.WriteLine(riddleFive["Q"]);

    //         string userInput5 = Console.ReadLine();

    //         if (userInput5 == riddleFive["A1"] || userInput5 == riddleFive["A2"]) 
    //         {
    //           Console.WriteLine("You have passed my test, however you will still be my dinner Muahahaha!"); 
    //         }
    //         else 
    //         {
    //           Console.WriteLine("YOU DIED- Sphinx ate you");
    //         }
    //       }
    //       else 
    //       {
    //         Console.WriteLine("YOU DIED- Sphinx ate you");
    //       }
    //     }
    //     else 
    //     {
    //       Console.WriteLine("YOU DIED- Sphinx ate you");
    //     }
    //   }
    //   else
    //   {
    //     Console.WriteLine("YOU DIED- Sphinx ate you");
    //   }
//     }
//     else 
//     {
//       Console.WriteLine("YOU DIED- Sphinx ate you");
//     }
//   }

// }