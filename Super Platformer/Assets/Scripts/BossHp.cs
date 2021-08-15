using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHp : MonoBehaviour
{
    [SerializeField] int health = 40;
    [SerializeField] GameObject death;
    public void TakeDamage(int damage){
        health -= damage;
        if(health <=0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
        Instantiate(death, transform.position, transform.rotation);
        Instantiate(death, transform.position, transform.rotation);
    }
}
