using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHeaith = 100;
    public int currentHealth { get; private set; }
    public Stats damage;
    public Stats armor;
    // Start is called before the first frame update
    private void Awake()
    {
        currentHealth = maxHeaith;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
