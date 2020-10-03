using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMario : MonoBehaviour, ClickAction
{
    private SceneHandler sceneHandler;

    void Start()
    {
        sceneHandler = GameObject.FindGameObjectWithTag("SceneHandler").GetComponent<SceneHandler>();
    }
    public void doAction()
    {
        sceneHandler.SaveScene();
        Cursor.lockState = CursorLockMode.Confined;
        sceneHandler.LoadScene(1);
    }

}
