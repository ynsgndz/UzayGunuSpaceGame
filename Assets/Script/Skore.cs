using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skore : MonoBehaviour
{

    public Text Degisenyazi;
    public Text Degisenyazi2;
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.HasKey("SeninSkor") && PlayerPrefs.HasKey("maxSkor"))
        {

            int yuksekSkor = PlayerPrefs.GetInt("maxSkor");
            int seninSkor = PlayerPrefs.GetInt("SeninSkor");
            Degisenyazi.text = "En Yüksek Skor: " + yuksekSkor;
            Degisenyazi2.text = "Suanki Skorun : " + seninSkor;
        }

    }
  
    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            PlayerPrefs.SetInt("maxSkor", 0);
            PlayerPrefs.SetInt("SeninSkor", 0);
        }
    }
}
