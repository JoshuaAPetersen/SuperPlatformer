using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager musicManagerInstance;
    void Awake() 
    {
        DontDestroyOnLoad(transform.gameObject);

        if(musicManagerInstance == null){
            musicManagerInstance = this;
        }else{
            Destroy(gameObject);
        }
    }
}
