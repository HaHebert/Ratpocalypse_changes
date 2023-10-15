using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat_Mob_Weapon : MonoBehaviour
{
	public int damage;
	public Vector3 attackOffset;
	public float attackRange = 1f;

	public void Attack()
	{
		Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, attackRange);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Player"))
            {
                collider.GetComponent<PlayerHealth>().damageEnemy(damage);
            }
        }
	}
	
}