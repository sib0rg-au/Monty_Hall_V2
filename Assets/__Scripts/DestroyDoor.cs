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
    public MontyHallGame doorInt, timerCheck;
    public bool openDoor1 = false;

    // Update is called once per frame
    void Update()
    {



        if (doorInt.playerChoice != 0 && doorInt.doorToOpen == 1 && timerCheck.expiredTimer == 0)
        {
            //doorDestroy1.GetComponent<Animation>().Play;


            doorDestroy1.GetComponent<Animation>().Play();
            Destroy(buttonDestroy1);
            openDoor1 = true;
            


        }
        else if (doorInt.playerChoice != 0 && doorInt.doorToOpen == 2 && timerCheck.expiredTimer == 0)
        {
            doorDestroy2.GetComponent<Animation>().Play();
            Destroy(buttonDestroy2);
            //Destroy(doorDestroy2);
        }
        else if (doorInt.playerChoice != 0 && doorInt.doorToOpen == 3 && timerCheck.expiredTimer == 0)
        {
            doorDestroy3.GetComponent<Animation>().Play();
            Destroy(buttonDestroy3);
            //Destroy(doorDestroy3);
        }

    }




    


}
