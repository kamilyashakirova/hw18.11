using System;
public class BeachGame : Game
{
    public override void Play(string tname)
    {
        Console.WriteLine("команда {0} играет на пляже", tname);
    }
}
