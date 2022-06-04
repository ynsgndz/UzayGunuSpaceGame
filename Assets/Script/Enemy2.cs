using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Transform playerPos;
    int canHakki=2;
    int maXcanHakki=2;
    public float speed;
    public GameObject[] kalpler;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("spaceShip").GetComponent<Transform>();

    }

    void Update()
    {
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
            can_sistemi();
            if (canHakki <= 0)
            {
                Destroy(gameObject);
            }

        }
       

    }
    void can_sistemi()
    {
        for (int i = 0; i < maXcanHakki; i++)
        {
            kalpler[i].SetActive(false);
        }
        for (int i = 0; i < canHakki; i++)
        {
            kalpler[i].SetActive(true);
        }
    }
}
