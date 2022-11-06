using System;

namespace TrueOrFalse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // define questions, answers, and user responses arrays     
      string [] questions = new string[]
      {
        "Seahorses have stomachs for the absorption of nutrients from food",
       "The letter H is between letters G and J on a keyboard",
       "Camels have three sets of eyelashes",
       "There are five zeros in one hundred thousand",
       "New York is nicknamed 'The Big Orange'",
       "The moon is just 50 percent of the mass of Earth."        
        };
      bool[] answers = new bool[]
      {
        false,
        true,
        true,
        true,
        false,
        false
      };
      // same length as question array
      bool[] responses= new bool[questions.Length];

      //check if the length of questions and responses are the same
      if(questions.Length != responses.Length)
      {       
       Console.WriteLine("Warning! The number of questions doesn't match the number of responses.");
      }
      
     int askingIndex = 0;

     //loop though questions array
     foreach(string question in questions)
     {
      string input;
      bool isBool;
      bool inputBool;

       Console.WriteLine(question);
       Console.WriteLine("True or False ?");
       input = Console.ReadLine();
	     
       //check if the user’s input can be converted to a boolean.
       isBool = Boolean.TryParse(input, out inputBool);

       // continue looping while isBool is false
      while (!isBool) 
      {
      Console.WriteLine("Please respond with 'true' or 'false'.");
      input = Console.ReadLine();
      isBool = Boolean.TryParse(input, out inputBool);
      }

     }

    }
  }
}
