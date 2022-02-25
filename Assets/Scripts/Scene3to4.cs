using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace First_Main_Scene
{
    public class Scene3to4 : MonoBehaviour
    {
        public bool Trigger;
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Player")
            {
                Trigger = true;
                //SceneManager.LoadScene(2);

            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Trigger = false;
                //SceneManager.LoadScene(2);

            }
        }

        private void Update()
        {
            if (Trigger == true && Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}

