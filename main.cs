using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Hello World");
    while (true)
    {
      Console.WriteLine("Enter a number: ");
      Int32 myNumber = Convert.ToInt32(Console.ReadLine());

      if (myNumber % 2 == 0) 
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Number is even.");
      }
      else 
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Number is odd.");
      }
    }
  }
}
//Stephen saw Brian's Big Dong