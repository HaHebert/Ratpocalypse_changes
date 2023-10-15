using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alligator_Controller : MonoBehaviour
{
    public Transform player;

    public bool isFlipped = false;

    //hp calls / variables
    public int maxHealth = 100;
    public int currentHealth;
    public Alligator_healthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        //TESTING HP BAR 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }


    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}


