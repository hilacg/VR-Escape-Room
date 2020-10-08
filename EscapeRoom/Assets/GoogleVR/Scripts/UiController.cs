using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public TextMesh text;
    public TextMesh text1;
    public Transform man;
    public Transform cam;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //text.text = Input.GetAxis("Vertical").ToString();
        //text1.text = Input.GetAxis("Horizontal").ToString();


        //foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        //{
        //    if (Input.GetKey(kcode))
        //    {
        //        text.text = kcode.ToString();
        //    }
        //}
        //////RaycastHit hit;
        ////Vector2 vector = new Vector2(Screen.width / 2f, Screen.height / 2f);
        ////Ray ray = Camera.main.ScreenPointToRay(vector);
        ////if (Physics.Raycast(ray, out hit))
        ////{

        //if (kcode.ToString().Contains("Joystick") && kcode.ToString().Contains("Button0"))
        //{
        //    if (Input.GetKey(kcode))
        //    {
        //        text.text = kcode.ToString();
        //    }
        //}
        //if (hit.transform != null)
        //{
        //    //Debug.Log(hit.transform.name.ToString());
        //    if (hit.transform.GetComponent<KeyPadButton>())
        //    {
        //        //hit.transform.GetComponent<KeyPadButton>().OnClick();

        //        //Debug.Log("Hi you pressed on " + hit.transform.name);
        //    }
        //}
    }
    //foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
    //{
    //    if (Input.GetKey(kcode))
    //        text.text = kcode.ToString();

    //}

}
