using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
   [SerializeField] GameObject door;
    [SerializeField] bool doorOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(){
        if (doorOn == false){
            door.SetActive(true);
        }

    }
}
