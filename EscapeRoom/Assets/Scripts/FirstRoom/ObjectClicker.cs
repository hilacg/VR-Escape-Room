using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10f))
            {
                if (hit.transform)
                {
                    doAction(hit.transform.gameObject);
                }
            }
        }
    }

    protected void doAction(GameObject i_gameObject)
    {
        ClickAction action = i_gameObject.GetComponent<ClickAction>();
        if(action != null)
        {
            action.doAction();
        }
    }
}
