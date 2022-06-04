using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4SpawnCont1 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    float interval = 5f;
 
    void Start()
    {
        InvokeRepeating("spawn", 5f, interval);
     
    }

    // Update is called once per frame
    private void spawn()
    {
        int randPost = Random.Range(0, spawnPoints.Length);
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoints[randPost].position, Quaternion.identity);
    }

    void FixedUpdate()
    {
       
    }

}
