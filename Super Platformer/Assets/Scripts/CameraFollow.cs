using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float smoothSpeed = 0.125f;
    [SerializeField] Vector3 offset;
    void FixedUpdate(){
        if(player != null){
        Vector3 goodPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, goodPosition, smoothSpeed);
        transform.position = goodPosition;
        }
    }
}
