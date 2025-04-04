using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 100;
    private int currentHealth; //ojbect's current health
	//handle EasterEgg
    private EasterEggManager easterEggManager;

    private void Start()
    {
        currentHealth = maxHealth; // Set the initial health
        easterEggManager = FindObjectOfType<EasterEggManager>();//find every object contains EasterEggManager layout
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            if (easterEggManager != null)
            {
                easterEggManager.OnObjectDestroyed(gameObject);
            }

            Destroy(gameObject);
        }
    }
}
