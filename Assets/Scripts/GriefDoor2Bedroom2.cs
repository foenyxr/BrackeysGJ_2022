using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace First_Main_Scene
{
    public class GriefDoor2Bedroom2 : MonoBehaviour

    {
        public bool Trigger;
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Player")
            {
                Trigger = true;
                Debug.Log("enter");


            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Trigger = false;
                Debug.Log("exit");


            }
        }

        private void Update()
        {
            if (Trigger == true && Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(7);
            }
        }


    }
}

