using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickStart : MonoBehaviour
{
    public Material[] materials;
    private Renderer rend;
    void Update()
    {
        if (rend == null)
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = materials[0];
        }

        checkInput();
    }

    public void checkInput()
    {

        if (Input.GetMouseButton(0))
        {
            rend.sharedMaterial = materials[1];
            //Application.LoadLevel(0);
            SceneHandler sceneHandler = GameObject.FindGameObjectWithTag("SceneHandler").GetComponent<SceneHandler>();
            sceneHandler.LoadScene();
        }
        else
        {
            rend.sharedMaterial = materials[0];
        }
    }
}
