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

       
        
        if (collision.gameObject.name == "PlayerCapsule")
        {
            
            if (timerCheck.round2Timer > 0)
            
            
            {
                Debug.Log("Button green");
                GetComponent<Renderer>().material.color = Color.green;
                GetComponent<SphereCollider>().enabled = false;
                plyrCh.playerChoice = 1;

                disableButton2.GetComponent<SphereCollider>().enabled = false;
                disableButton3.GetComponent<SphereCollider>().enabled = false;


            }

            else 
                
                if (openedDoor.doorToOpen != 1)
            {
                GetComponent<SphereCollider>().enabled = true;
                secondChoice.swapOrStay = 1;

            }






        }
       



       



    }

    
}
