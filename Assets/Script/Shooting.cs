using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefap;
    public float bulletForce = 20f;
    [SerializeField]
   
    private void Start()
    {
   

    }
    void Update()
    {
        //Shoot();
     if(Input.GetButtonDown("Fire1"))
     {

         Shoot();
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
        
     }   
    }

    void Shoot(){
        GameObject bullet = Instantiate(bulletPrefap, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up*bulletForce, ForceMode2D.Impulse);
    }
}
