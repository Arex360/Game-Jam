using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAddOns : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;
    
    [SerializeField] private float maxDamage = 100f;
    [SerializeField] private float currentDamage;

    [SerializeField] public HealthBar playerHealth;
    [SerializeField] private DamageBar playerDamageBar;

    void Start()
    {
        playerHealth.SetMaxHealth(maxHealth);
        playerHealth.SetHealth(currentHealth);
        playerDamageBar.SetMaxDamage(maxDamage);
        playerDamageBar.SetDamage(currentDamage);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerHealth.IncreaseHealth(20f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerHealth.DecreaseHealth(10f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            playerDamageBar.IncreaseDamage(20f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            playerDamageBar.DecreaseDamage(10f);
        }
    }
}
