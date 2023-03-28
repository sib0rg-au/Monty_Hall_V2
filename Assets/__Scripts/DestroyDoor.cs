using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
    public GameObject doorDestroy1;
    public GameObject doorDestroy2;
    public GameObject doorDestroy3;
    public GameObject buttonDestroy1;
    public GameObject buttonDestroy2;
    public GameObject buttonDestroy3;
    public GameObject sheep;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;

    public MontyHallGame doorInt, timerCheck;
    public bool openDoor1 = false;

    public bool spawn1 = false;
    public bool spawn2 = false;
    public bool spawn3 = false;

    private float timer = 1;
    // Update is called once per frame
    void Update()

    //public void OpenDoor()
    {


        //Once a player has made a choice, the timer has ended and door to open selected, then open the door and spawn the sheep


        //Play the animation and spawn the sheep if the door to open is door 1
        if (doorInt.playerChoice != 0 && doorInt.doorToOpen == 1 && timerCheck.expiredTimer == 0)
        {
            
            while (timer > 0)
            {
                timer -= Time.deltaTime;
                doorDestroy1.GetComponent<Animation>().Play();
               
            }

            while(spawn1 == false)
            {
                Instantiate(sheep, spawnPoint1.transform);
                spawn1 = true;
            }
            //deactivate button by removing its collider and changing colour to clear
            buttonDestroy1.GetComponent<SphereCollider>().enabled = false;
            buttonDestroy1.GetComponent<Renderer>().material.color = Color.clear;




        }
        //Play the animation to open door 2 and spawn the sheep if the door to open is door 2
        else if (doorInt.playerChoice != 0 && doorInt.doorToOpen == 2 && timerCheck.expiredTimer == 0)
        {
            while (timer > 0)
            {
                timer -= Time.deltaTime;
                doorDestroy2.GetComponent<Animation>().Play();
            }

            while (spawn2 == false)
            {
                Instantiate(sheep, spawnPoint2.transform);
                spawn2 = true;
            }

            buttonDestroy2.GetComponent<SphereCollider>().enabled = false;
            buttonDestroy2.GetComponent<Renderer>().material.color = Color.clear;
            
        }

        //Play the animation to open door 3 and spawn the sheep if the door to open is door 3
        else if (doorInt.playerChoice != 0 && doorInt.doorToOpen == 3 && timerCheck.expiredTimer == 0)
        {
            while (timer > 0)
            {
                timer -= Time.deltaTime;
                doorDestroy3.GetComponent<Animation>().Play();
            }

            while (spawn3 == false)
            {
                Instantiate(sheep, spawnPoint3.transform);
                spawn3 = true;
            }

            buttonDestroy3.GetComponent<SphereCollider>().enabled = false;
            buttonDestroy3.GetComponent<Renderer>().material.color = Color.clear;
            
        }

    }




    


}
