using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] GameObject death;
    [SerializeField] float deathSpawns = 1;
    public void TakeDamage(int damage){
        health -= damage;
        if(health <=0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
        while(deathSpawns > 0){
        deathSpawns--;
        Instantiate(death, transform.position, transform.rotation);
        }
    }
}
