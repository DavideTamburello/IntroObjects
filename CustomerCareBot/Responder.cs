using System;

namespace CustomerCareBot;

public class Responder
{
    public Dictionary<string, string> responseMap = new Dictionary<string, string>();
    // responseMap.Add("file manager", "That is explained in the manual. Have you read the manual?");
    // responseMap.Add("bug", "Well, you know, all software has some bugs. But our software engineers are working very hard to fix them. Can you describe the problem a bit further?");
    // responseMap.Add("performance", "Performance was quite adequate in all our tests. Are you runningany other processes in the background?");
    
    List<string> defaultResponses = new List<string>{ "risposta1", "risposta2", "risposta3"};
    public string GenerateResponse(HashSet<string> words)
    {
        
    }
}
