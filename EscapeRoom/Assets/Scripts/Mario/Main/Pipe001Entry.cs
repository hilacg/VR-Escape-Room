using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Entry : MonoBehaviour
{

    [SerializeField] public GameObject PipeEntry;
    
    private int StoodOn;
   
    void Start()
    {
        PipeEntry.GetComponent<Animator>().enabled = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }
    public void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    public void Update()
    {
        if (Input.GetButtonDown("GoDown") && StoodOn == 1)
        {
            this.transform.position = new Vector3(0, -1000, 0);
            StartCoroutine(WaitingForPipe());
        }
    }


    IEnumerator WaitingForPipe()
    {
        PipeEntry.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2);
        PipeEntry.GetComponent<Animator>().enabled = false;
        PipeEntry.transform.position = new Vector3(0, -1000, 0);
        Application.LoadLevel(3);
    }
}
