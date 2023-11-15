class Program
{
    static void Main()
    {
        BigRace gg = new BigRace();

        string[] ts = { "Россия", "Франция", "Китай", "Казахстан" };

        foreach (var t in ts)
        {
            gg.PlayGames(t);
        }
    }
}
