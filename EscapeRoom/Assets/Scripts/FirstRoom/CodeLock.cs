using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLock : MonoBehaviour
{
    [SerializeField] public GameObject GreenLight;
    [SerializeField] public GameObject RedLight;
    [SerializeField] public GameObject toOpen;
    [SerializeField] public string code = "";

    public string attemptedCode;

    private Animator animator;
    private int codeLength;
    

    

    private void Start()
    {
        codeLength = code.Length;
        RedLight.SetActive(true);
        GreenLight.SetActive(false);
        animator = toOpen.GetComponent<Animator>();
    }

    void CheckCode()
    {
        if(attemptedCode == code)
        {
            //open the door safe
            animator.Play("Door Open");
            RedLight.SetActive(false);
            GreenLight.SetActive(true);

        }
        else
        {
            Debug.Log("Worng Code");
            RedLight.SetActive(false);
            GreenLight.SetActive(true);
        }
    }

    IEnumerator Open()
    {
        toOpen.transform.Rotate(new Vector3(0, 90, 0), Space.World);

        yield return new WaitForSeconds(4);

        toOpen.transform.Rotate(new Vector3(0, -90, 0), Space.World);

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
