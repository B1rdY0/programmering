using System;
using System.Threading;

Console.WriteLine("?: HEYYYYYYYYYYYYYYY WHO ARE YOU?: ");

string name; 

name = Console.ReadLine();

Console.WriteLine($"?: hey {name} that's pretty bruh");

Thread.Sleep (1000);

Console.WriteLine("?: let me ask you a question?");

Thread.Sleep (1000);

Console.WriteLine("?: u like games?");

Thread.Sleep (1000);

System.Console.WriteLine("?: Choose between: yes,nah or somewhat");

Thread.Sleep (1000);

string answer;
answer = Console.ReadLine();

if (answer == "yes" )
{
   Console.WriteLine("?: Nice what games u like"); 
   Thread.Sleep (1000);
   Console.WriteLine("You: choose between: idk, just kidding i don't like games");
   string svar = Console.ReadLine();
   
   Thread.Sleep (1000);
    if  (svar == "just kidding i don't like games")
       {
           Console.WriteLine("?: bruh, u wasted both of our time, bye.");
            
       }
   if (svar == "idk")
   {
       Console.WriteLine("?: Alright then, there is many diffrent types of games, so what do you like?");
       Thread.Sleep (1000);
       Console.WriteLine("You: choose between: FPS or open world");  
   }    
   string svar_3 = Console.ReadLine();
   if (svar_3 == "FPS")
   {
       Console.WriteLine("?: Cool, let me show you something then");
   }
   if (svar_3 == "open world")
   {
       Console.WriteLine("nice, let me show you something");
   }
   Console.ReadLine();
}

if (answer == "nah")
{
    Console.WriteLine("?: eh ur boring, bye" );
}

if (answer == "somewhat")
{ 
    Console.WriteLine("?: let me show you some good games");
    Thread.Sleep(1000);
    Console.WriteLine("You: Like what?");
    Thread.Sleep(1000);
    Console.WriteLine("?: I'll let you try some of my games if you come, that is if you trust me. ");
    Thread.Sleep(1000);
    System.Console.WriteLine("You: ...sure...");
    string svar_2 = Console.ReadLine();
    
    if (svar_2 == "...sure...")
    {
        Console.WriteLine("fallow me then :)");
        
    }
}
Console.ReadLine();
