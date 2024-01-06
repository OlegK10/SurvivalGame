using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
        private set { health = value; }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        private set { maxHealth = value; }
    }

    public int Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    public int Thirst
    {
        get { return thirst; }
        private set { thirst = value; }
    }

    public int Hunger
    {
        get { return hunger; }
        private set { hunger = value; }
    }

    public int Energy
    {
        get { return energy; }
        private set { energy = value; }
    }

    public bool IsPoisoned
    {
        get { return isPoisoned; }
        private set { isPoisoned = value; }
    }

    public bool IsInfected
    {
        get { return isInfected; }
        private set { isInfected = value; }
    }


}
