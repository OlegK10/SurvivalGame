using System;

public class Player
{
    private int health;
    private int maxHealth;
    private int speed;
    private int thirst;
    private int hunger;
    private int energy;
    private bool isPoisoned;
    private bool isInfected;

    public Player(int health, int speed, int thirst, int hunger, int energy, int maxHealth)
    {
        Health = health;
        Speed = speed;
        Thirst = thirst;
        Hunger = hunger;
        MaxHealth = maxHealth;
        Energy = energy;
        IsPoisoned = false;
        IsInfected = false;
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int Thirst
    {
        get { return thirst; }
        set { thirst = value; }
    }

    public int Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }

    public int Energy
    {
        get { return energy; }
        set { energy = value; }
    }

    public bool IsPoisoned
    {
        get { return isPoisoned; }
        set { isPoisoned = value; }
    }

    public bool IsInfected
    {
        get { return isInfected; }
        set { isInfected = value; }
    }
}
