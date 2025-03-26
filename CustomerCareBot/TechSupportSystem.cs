using System;

namespace CustomerCareBot;

public class TechSupportSystem
{
    public string PrintWelcome()
    {
        return "Welcome to the GreppiSoft Technical Support System. \n Please tell us about your problem. \n We will assist you with any problem you might have. \n Please type 'bye' to exit our system.";
    }
    public string PrintGoodbye()
    {
        return "Nice talking to you. Bye...";
    }
    public string Start()
    {
        if (Console.ReadLine().ToLower().Contains("bye"))
        {
            return PrintGoodbye();
        }
        return //risposta
    }
}
