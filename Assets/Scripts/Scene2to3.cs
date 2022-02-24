using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2to3 : MonoBehaviour
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
            SceneManager.LoadScene(2);
        }
    }
}
