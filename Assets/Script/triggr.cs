using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class triggr : MonoBehaviour
{

    public GameObject HeartPrefap1;
    public GameObject HeartPrefap2;
    public Text Degisenyazi2;
    public Text KalkanText;
    public GameObject HeartPrefap3;

    public static int kalkanKorumasi = 0;
    int can = 3;
    
    void Start()
    {
          

    }

    // Update is called once per frame
    void Update()
    {
        KalkanText.text ="Kalkan: "+kalkanKorumasi;
       
       int  maxSkor = int.Parse(Degisenyazi2.text);

        if (can <= 0 && kalkanKorumasi <= 0)
        {
            int yuksekSkor = PlayerPrefs.GetInt("maxSkor");
            if (maxSkor > yuksekSkor)
            {
                PlayerPrefs.SetInt("maxSkor", maxSkor);
                PlayerPrefs.SetInt("SeninSkor", maxSkor);
            }
            else
            {
                PlayerPrefs.SetInt("SeninSkor", maxSkor);
            }
            SceneManager.LoadScene("secondScene");
           
               Destroy(gameObject);
            }
    }

    void OnCollisionEnter2D(Collision2D collision){
        //çarpma işlemi olduğunda 1 kez çalışır.
        if (collision.gameObject.tag == "kalkan")
        {
            kalkanKorumasi++;
        }

        
        if (collision.gameObject.tag=="bullet" || collision.gameObject.tag == "enemy" || collision.gameObject.tag == "enemy2")
        {
            if (kalkanKorumasi > 0)
            {
                kalkanKorumasi--;

            }
            else
            {
                can--;

                if (can == 0) { Destroy(HeartPrefap2); }
                if (can == 1) { Destroy(HeartPrefap1); }
                if (can == 2) { Destroy(HeartPrefap3); }

            }

         

        }
              
            
}
 }





