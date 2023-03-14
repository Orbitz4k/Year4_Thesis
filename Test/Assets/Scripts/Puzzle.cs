using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int sceneNumber;

    public ParticleSystem particleEffect;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            Destroy(collision.gameObject)
        }

    }
}
