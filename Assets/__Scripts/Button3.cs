using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public MontyHallGame plyrCh;
    public Button1 disableButton1;
    public Button2 disableButton2;
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "PlayerCapsule")
        {
            Debug.Log("Button green");
            GetComponent<Renderer>().material.color = Color.green;

            plyrCh.playerChoice = 3;

            disableButton2.GetComponent<SphereCollider>().enabled = false;
            disableButton1.GetComponent<SphereCollider>().enabled = false;
        }






    }
}
