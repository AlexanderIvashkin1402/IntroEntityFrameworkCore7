namespace TaskManager.Model;

public class Status
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
