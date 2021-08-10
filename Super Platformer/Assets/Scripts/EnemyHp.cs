using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] GameObject death;
    public void TakeDamage(int damage){
        health -= damage;
        if(health <=0){
            Die();
        }
    }
    void Die(){
        Instantiate(death, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
