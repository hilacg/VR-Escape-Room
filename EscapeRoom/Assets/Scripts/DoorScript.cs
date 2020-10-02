using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] public GameObject Door;
    // Start is called before the first frame update
    public void Start()
    {
        Door.GetComponent<Animator>().enabled = false;
    }


    public void Update()
    {
       
            Door.GetComponent<Animator>().enabled = true;
    }
}
