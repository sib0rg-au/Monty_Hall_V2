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
    public int carSpawn = 0;

    //public Button Button1;
    //public Button Button2;
    //public Button Button3;

    public DestroyDoor openDoor, spawnCar, doorAnimate;
    public GameObject NewCar;
    

    private bool gameRestarting;
    private bool carSpawned = false;

    public float timer = 400;
    public float round2Timer = 5;
    public float round3Timer = 5;
    



    // Start is called before the first frame update

    void Start()
    {
        //pick a winning door
        winningDoor = 
            Random.Range(1, 4);


    }

   
    // Update is called once per frame
    void Update()
    {
      //pick a door to open, that is not the player choice or the winning door
        while(doorToOpen == winningDoor ||doorToOpen == playerChoice)
        {
            doorToOpen = Random.Range(1, 4);
        }
//Once the player has made a choice, start the first timer
        if (playerChoice != 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
                expiredTimer= 0;
                Debug.Log("You chose door " + playerChoice);
                

            }
        }
      
        
     if(expiredTimer == 0)
        {
            //round 2 timer is added to provide instructions and a delay before remaining buttons are reactivated
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
                    //addB2Collider.AddComponent<SphereCollider>();
                }
            }
           

        }  
     //Once the player has made their second choice, start a timer to reveal the winning door and prize
     if (swapOrStay != 0)
        {
            round3Timer -= Time.deltaTime;
            Debug.Log("Your final choice is door " + swapOrStay);
            if (round3Timer < 0)
            {
                round3Timer = 0;
                while (winningDoor == 1 && carSpawned == false)
                {
                    //spawn in the car and open the door
                    Instantiate(NewCar, spawnCar.spawnPoint1.transform);
                    doorAnimate.doorDestroy1.GetComponent<Animation>().Play();
                    carSpawned = true;
                }

                while (winningDoor == 2 && carSpawned == false)
                {
                    Instantiate(NewCar, spawnCar.spawnPoint2.transform);
                    doorAnimate.doorDestroy2.GetComponent<Animation>().Play();
                    carSpawned = true;
                }

                while (winningDoor == 3 && carSpawned == false)
                {
                    Instantiate(NewCar, spawnCar.spawnPoint3.transform);
                    doorAnimate.doorDestroy3.GetComponent<Animation>().Play();
                    carSpawned = true;
                }

                //Check winning conditions for the probability game and play relevent audio (here as a debug log)
                if(swapOrStay == winningDoor)
                {
                    if (playerChoice == swapOrStay)
                    {
                        Debug.Log("You chose correctly and stuck to your choice!");

                    }
                    else
                    {
                        Debug.Log("You chose correctly by changing your mind!");
                    }    
                        
                }
                else
                {
                    if (playerChoice == swapOrStay)
                    {
                        Debug.Log("You didn't win this time and you stuck with your decision");
                    }
                    else
                    {
                        Debug.Log("You didn't win this time and you changed your choice!");
                    }
                }
            }
        } 
    }
}
