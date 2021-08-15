using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornCollect : MonoBehaviour
{
    [SerializeField] float acornValue = 1;

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            Destroy(gameObject);
            AcornScore.instance.ChangeScore(acornValue);
        }
    }
}
