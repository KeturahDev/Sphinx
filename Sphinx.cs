using System;
using System.Collections.Generic;


class Sphinx
{
  // Random rnd = new Random();

  public static Dictionary<string, string> riddleOne = new Dictionary<string, string>() { {"Q", "The more of them you take, the more you leave behind. What are they?"}, {"A1", "footsteps"}, {"A2", "Footsteps"} };
  
  public static Dictionary<string, string> riddleTwo = new Dictionary<string, string>() { {"Q", "What is more useful when it is broken?"}, {"A1", "Egg"}, {"A2", "egg"} };
  
  public static Dictionary<string, string> riddleThree = new Dictionary<string, string>() { {"Q", "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?"}, {"A1", "Fire"}, {"A2", "fire"} };
  
  public static Dictionary<string, string> riddleFour = new Dictionary<string, string>() { {"Q", "What runs around the whole yard without moving?"}, {"A1", "Fence"}, {"A2", "fence"}, {"A3", "a fence"}};
  
  public static Dictionary<string, string> riddleFive = new Dictionary<string, string>() { {"Q", "What can you catch but never throw?"}, {"A1", "a cold"}, {"A2", "A cold"} };

  // Dictionary<string, string>[] library = new Dictionary<string, string>[]
  // {
  // new Dictionary<string, string>() { {"Q", "The more of them you take, the more you leave behind. What are they?"}, {"A1", "footsteps"}, {"A2", "Footsteps"} },
  
  // new Dictionary<string, string>() { {"Q", "What is more useful when it is broken?"}, {"A1", "Egg"}, {"A2", "egg"} },
  
  // new Dictionary<string, string>() { {"Q", "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?"}, {"A1", "Fire"}, {"A2", "fire"} },
  
  // new Dictionary<string, string>() { {"Q", "What runs around the whole yard without moving?"}, {"A1", "Fence"}, {"A2", "fence"}, {"A3", "a fence"}},
  
  // new Dictionary<string, string>() { {"Q", "What can you catch but never throw?"}, {"A1", "a cold"}, {"A2", "A cold"} }
  // }

  static void Main()
  {
    Console.WriteLine("I AM SPHINX! ANSWER MY RIDDLES OR DIE");
    Console.WriteLine(riddleOne["Q"]);
    string userInput = Console.ReadLine();

    if (userInput == riddleOne["A1"] || userInput == riddleOne["A2"])
    {
      Console.WriteLine("You live... FOR NOW!");
      Console.WriteLine(riddleTwo["Q"]);

      string userInput2 = Console.ReadLine();

      if (userInput2 == riddleTwo["A1"] || userInput2 == riddleTwo["A2"]) 
      {
        Console.WriteLine("You live... FOR NOW!"); 
        Console.WriteLine(riddleThree["Q"]);

        string userInput3 = Console.ReadLine();

        if (userInput3 == riddleThree["A1"] || userInput3 == riddleThree["A2"]) 
        {
          Console.WriteLine("You live... FOR NOW!"); 
          Console.WriteLine(riddleFour["Q"]);
                  
          string userInput4 = Console.ReadLine();

          if (userInput4 == riddleFour["A1"] || userInput4 == riddleFour["A2"]) 
          {
            Console.WriteLine("You live... FOR NOW!"); 
            Console.WriteLine(riddleFive["Q"]);

            string userInput5 = Console.ReadLine();

            if (userInput5 == riddleFive["A1"] || userInput5 == riddleFive["A2"]) 
            {
              Console.WriteLine("You have passed my test, however you will still be my dinner Muahahaha!"); 
            }
            else 
            {
              Console.WriteLine("YOU DIED- Sphinx ate you");
            }
          }
          else 
          {
            Console.WriteLine("YOU DIED- Sphinx ate you");
          }
        }
        else 
        {
          Console.WriteLine("YOU DIED- Sphinx ate you");
        }
      }
      else
      {
        Console.WriteLine("YOU DIED- Sphinx ate you");
      }
    }
    else 
    {
      Console.WriteLine("YOU DIED- Sphinx ate you");
    }
  }

}