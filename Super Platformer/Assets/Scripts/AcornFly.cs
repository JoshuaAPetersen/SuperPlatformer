using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornFly : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] int damage;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo) {
        EnemyHp enemy = hitInfo.GetComponent<EnemyHp>();
        if(enemy != null){
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
