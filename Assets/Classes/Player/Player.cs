using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    public int Speed { get; private set; }
    public int Thirst { get; private set; }
    public int Hunger { get; private set; }
    public int Energy { get; private set; }
    public bool IsPoisoned { get; private set; }
    public bool IsInfected { get; private set; }

    public Player(int health, int speed, int thirst, int hunger, int energy)
    {
        Health = health;
        Speed = speed;
        Thirst = thirst;
        Hunger = hunger;
        Energy = energy;
        IsPoisoned = false;
        IsInfected = false;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void Heal(int amount)
    {
        Health = Mathf.Min(Health + amount, MaxHealth);
    }

    public void ChangeSpeed(int amount)
    {
        Speed = amount;
    }

    public void ChangeThirst(int amount)
    {
        Thirst = amount;
    }

    public void ChangeHunger(int amount)
    {
        Hunger = amount;
    }

    public void ChangeEnergy(int amount)
    {
        Energy = amount;
    }

    public void ChangePoisoned(bool value)
    {
        IsPoisoned = value;
    }

    public void ChangeInfected(bool value)
    {
        IsInfected = value;
    }
}
