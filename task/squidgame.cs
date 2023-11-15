using System;
public class SquidGame : Game
{
    public override void Play(string teamName)
    {
        Console.WriteLine("Команда {0} играет в кальмара", teamName);
    }
}