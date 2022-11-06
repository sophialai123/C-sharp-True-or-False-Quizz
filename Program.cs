using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
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
      //get user input
      input = Console.ReadLine();
      //covert user input string to boolean type
      isBool = Boolean.TryParse(input, out inputBool);
    }
   //store the user’s boolean answer
   responses[askingIndex] = inputBool;
   askingIndex++;

     }

     int scoringIndex =0;
     int score = 0;

   foreach(bool answer in answers)
   {
     //capture the response matching the answer.
    bool response= responses[scoringIndex];
    Console.WriteLine($"{scoringIndex +1} Input: {response} | Answer: {answer}");

    if(response == answer){
     score ++;
   }
   scoringIndex +=1;
   }
 
   Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
