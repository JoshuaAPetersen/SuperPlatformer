using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed = 5;
    void Update()
    {
        transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
    }
}
