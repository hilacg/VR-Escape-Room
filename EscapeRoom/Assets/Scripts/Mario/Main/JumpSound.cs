using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioSource audio;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            audio.Play();
        }
    }
}
