using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 1;
    public bool isRight;
    public float x;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack1();
        }
    }
    void Attack1()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            //enemy.GetComponent<Enemy>().GetDamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
