using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
   [SerializeField] GameObject enableDoor;
    [SerializeField] bool doorOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player" && doorOn == false){
            Destroy(gameObject);
            enableDoor.SetActive(true);
        }
    }
}
