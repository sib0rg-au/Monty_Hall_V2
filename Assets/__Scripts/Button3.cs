using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public MontyHallGame plyrCh, timerCheck, secondChoice;
    public Button1 disableButton1;
    public Button2 disableButton2;
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "PlayerCapsule")
        {
            Debug.Log("Button green");
            if (timerCheck.round2Timer > 0)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
                plyrCh.playerChoice = 3;
                Debug.Log("Yellow");
            }
            else
            {
                secondChoice.swapOrStay = 3;
                GetComponent<Renderer>().material.color = Color.green;

                //stop the player from selecting another button once final choice is made
                disableButton2.GetComponent<SphereCollider>().enabled = false;
                disableButton1.GetComponent<SphereCollider>().enabled = false;
            }

            
        }






    }
}
