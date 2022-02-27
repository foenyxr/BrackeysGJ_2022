using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace First_Main_Scene
{

    public class Writing : MonoBehaviour
    {

        public GameObject text;
        public GameObject text1;
        private bool Trigger;

        private void Start()

        {
            Debug.Log("start");
            text.SetActive(false);
            text1.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Player")
            {
                Debug.Log("enter");
                text.SetActive(true);
                text1.SetActive(true);

            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("exit");
                text.SetActive(false);
                text1.SetActive(false);

            }
        }
    }
}
