using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MontyHallGame : MonoBehaviour
{
    public int winningDoor;
    public int playerChoice;
    public int swapOrStay;
    public int doorToOpen;
    public int expiredTimer = 1;

    public Button Button1;
    public Button Button2;
    public Button Button3;

    private bool gameRestarting;

    public float timer = 400;



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
       
     if(timer == 0)
        {

        }  

      
    }
}
