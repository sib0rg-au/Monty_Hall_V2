using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Button1 : MonoBehaviour

    
{
    public MontyHallGame plyrCh, timerCheck,secondChoice,openedDoor;
    public Button2 disableButton2;
    public Button3 disableButton3;
 
    
    

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);

        //check for a collision
            if (collision.gameObject.name == "PlayerCapsule")
            {
                Debug.Log("Yellow");
                if (timerCheck.round2Timer > 0)
            {
                //change button colour
                GetComponent<Renderer>().material.color = Color.yellow;
                plyrCh.playerChoice = 1;
            }
                else
            {
                secondChoice.swapOrStay = 1;
                GetComponent<Renderer>().material.color = Color.green;
                
                //stop the player from selecting another button once final choice is made
                disableButton2.GetComponent<SphereCollider>().enabled = false;
                disableButton3.GetComponent<SphereCollider>().enabled = false;
            }

            


           
        }

            
        


                

       









    }

    
}
