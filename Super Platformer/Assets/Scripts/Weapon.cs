using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject acorn;
    [SerializeField] GameObject shot;
    [SerializeField] float fireRate = 0.5f;
    [SerializeField] float cooldown = 0.5f;

    // Update is called once per frame
    void Update()
    {
        fireRate -= 1 * Time.deltaTime;
        if(Input.GetButtonDown("Fire1") && fireRate <= 0){
            Shoot();
            fireRate = cooldown;
        }
    }
    void Shoot(){
        Instantiate(acorn, firePoint.position, firePoint.rotation);
        Instantiate(shot, firePoint.position, firePoint.rotation);
    }
}
