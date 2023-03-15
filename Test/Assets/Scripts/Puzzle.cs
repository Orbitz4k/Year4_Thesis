using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;

    public ParticleSystem particleEffect;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            Destroy(collision.gameObject);
            audioSource = GetComponent<AudioSource>();
            AddToLogFile.LogLine("Puzzle piece dropped");
            audioSource.clip = Scored;
            audioSource.Play();
        }
    }
}
