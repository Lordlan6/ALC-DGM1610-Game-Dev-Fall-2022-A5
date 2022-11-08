using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update() // Clean up code like this void
    {
        
    }
    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;

        if(currentHealth <= 0)
        {
            Debug.Log("You have done a great service to your country.");
            Destroy(gameObject,deathDelay);
        }
    }
}
