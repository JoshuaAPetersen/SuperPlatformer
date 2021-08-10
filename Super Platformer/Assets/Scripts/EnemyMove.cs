using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    
    [SerializeField] float speed = 2f;
    [SerializeField] bool moveRight;
    void Update()
    {
        if(moveRight){
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1,1);
        } else {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1,1);
        }
    }
}
