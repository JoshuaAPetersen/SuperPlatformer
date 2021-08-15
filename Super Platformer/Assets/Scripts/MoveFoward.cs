using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float moveSpeed = 1f;
    [SerializeField] float move = 5;
    [SerializeField] float nextMove = 5;
    void Start(){
        move = 0.5f;
    }
    void Update()
    {
        move -= 1 * Time.deltaTime;
        if (move <= 0){
        nextMove = Random.Range(1,5);
        // transform.Translate(2 * Time.deltaTime * moveSpeed, 0, 0);
        Vector3 posit = transform.position;
        Vector3 velocity = new Vector3( 0, moveSpeed * Time.deltaTime , 0);
        posit += transform.rotation * velocity;
        transform.position = posit;
        move = nextMove;
        }
    }
}
