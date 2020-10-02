using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour
{
    int codeLength;
    int placeInCode;

    public string code = "";
    public string attemptedCode;

    public Transform toOpen;

    private void Start()
    {
        codeLength = code.Length;
    }

    void CheckCode()
    {
        if(attemptedCode == code)
        {
            //open the door safe
            StartCoroutine(Open());

        }
        else
        {
            Debug.Log("Worng Code");
        }
    }

    IEnumerator Open()
    {
        toOpen.Rotate(new Vector3(0, 90, 0), Space.World);

        yield return new WaitForSeconds(4);

        toOpen.Rotate(new Vector3(0, -90, 0), Space.World);

    }

    // Update is called once per frame
    void Update()
    {
        if (Code.code.Length == codeLength)
        { 
            attemptedCode = Code.code;
        
            CheckCode();
            Code.code = "";
            attemptedCode = "";
        }
    }
}
