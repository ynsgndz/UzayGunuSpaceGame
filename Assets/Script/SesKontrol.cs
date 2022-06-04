using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip ates = default;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

  public void Ates()
    {
        audioSource.PlayOneShot(ates,0.4f);
    }
    
}
