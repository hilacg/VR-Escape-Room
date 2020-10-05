using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMario : MonoBehaviour, ClickAction
{
    // private SceneHandler sceneHandler;

    void Start()
    {
        // sceneHandler = GameObject.FindGameObjectWithTag("SceneHandler").GetComponent<SceneHandler>();
    }
    public void doAction()
    {
        //.SaveScene();
        PlayerPrefs.SetFloat("startTime", TimerDisplay.startTime);
        Cursor.lockState = CursorLockMode.Confined;
        //.LoadScene(1);
        Application.LoadLevel(1);
    }

}
