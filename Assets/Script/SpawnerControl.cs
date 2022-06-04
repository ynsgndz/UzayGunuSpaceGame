using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    float interval = 1f;
    
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, interval);
     
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
