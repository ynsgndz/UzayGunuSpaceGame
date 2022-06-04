using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour
{
     
    private void Start()
    {
 
            Destroy(gameObject, 4f);
  
    }
    private void Update() {
       
    }
void OnCollisionEnter2D(Collision2D collision){
         if(collision.gameObject.tag=="enemy")
        {
               Destroy(gameObject);
         }
        if (collision.gameObject.tag == "spaceShip")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "skor")
        {
            PlayerMovementScript.skor += 50;
            Destroy(gameObject);
        }
    }
}
