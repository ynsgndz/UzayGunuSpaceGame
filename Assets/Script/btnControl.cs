using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnControl : MonoBehaviour
{
    // Start is called before the first frame update
  
   public void OnButtonPress(){
        SceneManager.LoadScene("SampleScene");
        PlayerMovementScript.skor = 0;
        triggr.kalkanKorumasi = 0;
        PlayerPrefs.SetInt("SeninSkor", 0);
    }
     
}
