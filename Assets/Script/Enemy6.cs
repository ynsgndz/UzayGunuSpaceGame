using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy6 : MonoBehaviour
{
    private Transform playerPos;
    int canHakki = 1;
   
    public float speed;
    void Start()
    {
      

    }

    void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("spaceShip").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(
            transform.position,
            playerPos.position,
            speed * Time.deltaTime
            );
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //çarpma işlemi olduğunda 1 kez çalışır.

        if (collision.gameObject.tag == "spaceShip" || collision.gameObject.tag == "bullet")
        {

            
            canHakki--;
            
            if (canHakki == 0)
            {
                Destroy(gameObject);
            }
            Debug.Log("Can hakki " + canHakki);
        }
    }
     
}
