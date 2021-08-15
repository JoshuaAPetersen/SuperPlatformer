using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
   [SerializeField] GameObject disableDoor;
    [SerializeField] bool doorOff = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        
        if (other.tag == "Player" && doorOff == true){
            Destroy(gameObject);
            disableDoor.SetActive(false);
        }
    }
}
