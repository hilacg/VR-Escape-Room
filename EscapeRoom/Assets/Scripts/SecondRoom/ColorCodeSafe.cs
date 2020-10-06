using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCodeSafe : MonoBehaviour
{

    [SerializeField]
    private Animator animator;
    [SerializeField]
    public GameObject GreenLight;
    [SerializeField]
    public GameObject RedLight;
    [SerializeField]
    public string code = "";
    public string attemptedCode;
    private int codeLength;

    // Start is called before the first frame update

    private void Start()
    {
        codeLength = code.Length;
        RedLight.SetActive(true);
        GreenLight.SetActive(false);
    }
    void CheckCode()
    {
        if (attemptedCode == code)
        {
            //open the door safe
            animator.SetTrigger("OpenSafe");
            RedLight.SetActive(false);
            GreenLight.SetActive(true);


        }
        else
        {
            Debug.Log("Worng Code");
            RedLight.SetActive(true);
            GreenLight.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Code.code.Length == codeLength)
        {
            attemptedCode = Code.code;

            CheckCode();
            attemptedCode = "";
        }
    }
}
