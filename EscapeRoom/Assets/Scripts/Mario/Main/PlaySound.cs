using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audio;

    void Update()
    {
        if(audio == null)
        {
            audio = GetComponent<AudioSource>();
            print("null");
        }
        if (Input.GetKeyDown("space"))
        {
            audio.Play();
        }
    }
}
