using System;
public class SlideGame : Game
{
    public override void Play(string teamName)
    {
        Console.WriteLine("Команда {0} играет в мышеловку", teamName);
    }
}