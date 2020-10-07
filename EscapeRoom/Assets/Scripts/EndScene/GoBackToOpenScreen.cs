using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToOpenScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Application.LoadLevel(Scences.OpenScreen);
        }
    }
}
