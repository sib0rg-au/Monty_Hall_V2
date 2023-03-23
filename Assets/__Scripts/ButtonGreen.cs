using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGreen : MonoBehaviour
{

    bool buttonPressed = false;

  

  
         void OnCollisionEnter(Collision collision)

        {
          
            Debug.Log(collision.gameObject.name);

                       if (collision.gameObject.name == "PlayerCapsule")
        {
            Debug.Log("Button green");
            GetComponent<Renderer>().material.color = Color.green;
           buttonPressed= true;
        }

        //GameObject.FindGameObjectWithTag("Button1").SetActive(false);




    }
    }
