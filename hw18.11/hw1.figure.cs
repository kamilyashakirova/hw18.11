abstract class Figure
{
    protected string c;
    protected bool v;

    public Figure(string c, bool v)
    {
        this.c = c;
        this.visible = v;
    }
    public abstract void change(string newc);
    public abstract void status();
}
