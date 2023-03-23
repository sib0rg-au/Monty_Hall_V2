using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    bool ButtonOn = false;
    public float timer;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E)) 
            {
            ButtonOn= true;
            Debug.Log("Button on");
        }
    }
}
