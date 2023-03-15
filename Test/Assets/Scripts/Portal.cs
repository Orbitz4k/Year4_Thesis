using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AddToLogFile.LogLine("Moved Scenes");
            SceneManager.LoadScene(1);
        }
    }
}
