using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform playerPos;

    public float speed;
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("spaceShip").GetComponent<Transform>();

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            playerPos.position,
            speed*Time.deltaTime
            ) ;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //çarpma işlemi olduğunda 1 kez çalışır.

        if (collision.gameObject.tag == "spaceShip" || collision.gameObject.tag == "bullet")
        {


           Destroy(gameObject);
        }
        

    }
}
