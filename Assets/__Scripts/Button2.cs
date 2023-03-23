using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public MontyHallGame plyrCh;
    public Button1 disableButton1;
    public Button3 disableButton3;
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "PlayerCapsule")
        {
            Debug.Log("Button green");
            GetComponent<Renderer>().material.color = Color.green;

            plyrCh.playerChoice = 2;

            disableButton1.GetComponent<SphereCollider>().enabled = false;
            disableButton3.GetComponent<SphereCollider>().enabled = false;
        }
    }
}
