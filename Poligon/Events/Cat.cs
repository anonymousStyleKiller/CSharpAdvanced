namespace Poligon.Events;

public class Cat
{
    private int health;
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health
    {
        get => health;
        set
        {
            health = value;
            OnHealthChanged?.Invoke(this, health);
        }
    }

    public event EventHandler<int> OnHealthChanged; 
}