abstract class Figure
{
    protected string c;
    protected bool visible;

    public Figure(string c, bool visible)
    {
        this.c = c;
        this.visible = visible;
    }
    public abstract void change(string newc);
    public abstract void status();
}
