using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    void Start()
    {
        health = 10;
    }

    public void takeDamage(int damage)
    {
        health = health - damage;

        // update health bar GUI here

        if (health <= 0) // death
        {
            Time.timeScale = 0f;
        }
    }
}
