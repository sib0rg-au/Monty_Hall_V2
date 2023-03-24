using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public MontyHallGame plyrCh, timerCheck, secondChoice;
    public Button1 disableButton1;
    public Button3 disableButton3;
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);


        if (collision.gameObject.name == "PlayerCapsule")
        {
           
            if (timerCheck.round2Timer > 0)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
                plyrCh.playerChoice = 2;
                Debug.Log("Yellow");
            }
            else
            {
                secondChoice.swapOrStay = 2;
                GetComponent<Renderer>().material.color = Color.green;

                //stop the player from selecting another button once final choice is made
                disableButton1.GetComponent<SphereCollider>().enabled = false;
                disableButton3.GetComponent<SphereCollider>().enabled = false;
            }

            
        }
    }
}
