using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRadioClick : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField] 
    public GameObject Pannel;
    [SerializeField]
    public GameObject Blue;
    [SerializeField]
    public GameObject Red;
    [SerializeField]
    public GameObject Yellow;
    [SerializeField]
    public GameObject Green;
    void OnMouseDown()
    {
        if (SecondRoomCheck.IsBatteryFound())
        {
            anim.SetTrigger("RevealSafe");
            Pannel.SetActive(true);
            StartCoroutine(showClue());
        }
    }

    public IEnumerator showClue()
    {
        this.Blue.SetActive(true);
        yield return new WaitForSeconds(2);
       this.Blue.SetActive(false);
      this.Yellow.SetActive(true);
        yield return new WaitForSeconds(2);
        this.Yellow.SetActive(false);
        this.Red.SetActive(true);
        yield return new WaitForSeconds(2);
        this.Red.SetActive(false);
        this.Green.SetActive(true);
        yield return new WaitForSeconds(2);
        this.Green.SetActive(false);
    }
}
