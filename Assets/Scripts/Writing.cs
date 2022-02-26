using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace First_Main_Scene
{

    public class Writing : MonoBehaviour
    {

        public GameObject text;
        private bool Trigger;

        private void Start()

        {
            Debug.Log("start");
            text.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Player")
            {
                Debug.Log("enter");
                text.SetActive(true);

            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("exit");
                text.SetActive(false);

            }
        }
    }
}
