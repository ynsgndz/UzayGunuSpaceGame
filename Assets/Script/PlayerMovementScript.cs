
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovementScript : MonoBehaviour
{ 
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public static int skor = 0;
    public Text Degisenyazi;
 
    Vector2 movement;
    Vector2 mousePos;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        skor++;
        Degisenyazi.text =skor.ToString();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y ,lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;


       
    }
    

}
