public class BigRace
{
    private Game[] gs;

    public BigRace()
    {
        gs = new Game[]
        {
            new BeachGame(),
            new MouseTrap(),
            new SquidGame(),
            new Fishing(),
            new SlideGame(),
            new Postman()
        };
    }

    public void PlayGames(string team)
    {
        foreach (var g in gs)
        {
            g.Play(team);
        }
    }
}