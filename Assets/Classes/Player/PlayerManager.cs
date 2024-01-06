using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player player = null;

    public void InitPlayer()
    {
        player = new(100, 5, 100, 100, 100, 100);
    }

    public void Start()
    {
        InitPlayer();
    }
    public void Update()
    {
    }
    public void TakeDamage(int amount)
    {
        player.Health -= amount;

        if (player.Health <= 0)
        {
            Die();
        }

        Debug.Log(player.Health);
    }

    private void Die()
    {
        Debug.LogWarning("Player DIE");
        Destroy(gameObject);
    }

  

}
