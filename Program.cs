using System;

namespace deliverble2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userEngaged = true;
            string[] understoodWords = new string[4];
            understoodWords[0] = "hello";
            understoodWords[1] = "bye";
            understoodWords[2] = "sup";
            understoodWords[3] = "hellothere";

            string[] responses = new string[4];
            responses[0] = "Hi good to see you.";
            responses[1] = "Good Bye!";
            responses[2] = "I am good.";
            responses[3] = "General Kenobi";
            string previousResponse = "";
            Console.WriteLine("Hello. You are speaking to a bot. What would you like to say?");

            while (userEngaged)
            {
                string userInput = Console.ReadLine();
                string lowerInput = userInput.ToLower().Replace(" ", "");
                
                if(lowerInput == previousResponse)
                {
                    Console.WriteLine("You just said that.");
                   
                }
                    for (int i = 0; i < 4; i++)
                    {
                        if (lowerInput == understoodWords[i] )
                        {
                            Console.WriteLine(responses[i]);
                        }
                        if (lowerInput == "bye")
                        {
                            userEngaged = false;
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        
                    }
                 previousResponse = lowerInput;
            }
        }
    }
}
