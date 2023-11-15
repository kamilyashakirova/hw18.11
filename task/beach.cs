using System;
public class BeachGame : Game
{
    public override void Play(string teamName)
    {
        Console.WriteLine("Команда {0} играет на пляже", teamName);
    }
}
