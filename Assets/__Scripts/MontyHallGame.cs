using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MontyHallGame : MonoBehaviour
{
    public int winningDoor;
    public int playerChoice;
    public int swapOrStay;
    public int doorToOpen;
    public int expiredTimer = 1;

    //public Button Button1;
    //public Button Button2;
    //public Button Button3;

    public DestroyDoor openDoor;
    public Button1 addB1Collider;
    public Button2 addB2Collider;
    public Button3 addB3Collider;

    private bool gameRestarting;

    public float timer = 400;
    public float round2Timer = 5;



    // Start is called before the first frame update

    void Start()
    {
        winningDoor = Random.Range(1, 4);
        
    }

    

    public void CollideButton(int buttonSelect)
    {

    }

    public int PlayerChoice(int playerChoice)
    {


        return playerChoice;
    }

    // Update is called once per frame
    void Update()
    {
      while(doorToOpen == winningDoor ||doorToOpen == playerChoice)
        {
            doorToOpen = Random.Range(1, 4);
        }

        if (playerChoice != 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
                expiredTimer= 0;
                

            }
        }
       
     if(expiredTimer == 0)
        {
            //round 2 timer is added to provide instructions and a delay before remaining button are reactivated
           if (round2Timer > 0)
            {
                round2Timer -= Time.deltaTime;
                if (round2Timer < 0)
                {
                    round2Timer = 0;
                }

            }

           if (round2Timer == 0)
            {
                if (doorToOpen == 1)
                {
                    addB2Collider.AddComponent<SphereCollider>();
                }
            }
           

        }  

      
    }
}
