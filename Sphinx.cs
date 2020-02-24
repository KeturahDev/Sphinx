using System;

class Sphinx
{

  static void Main()
  {
    ReadOutRiddle();
    string userInput = Console.ReadLine();

    if (userInput == "footsteps" || userInput == "Footsteps")
    {
      Console.WriteLine("YOU Didnt die- Sphinx will ask you anaother ridddle");
    }
    else 
    {
      Console.WriteLine("YOU DIED- Sphinx ate you");
    }
  }

  static void ReadOutRiddle()
  {
    Console.WriteLine("The more of them you take, the more you leave behind. What are they?");
  }
}