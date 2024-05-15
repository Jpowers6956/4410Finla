using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip audioClip; // The audio clip to play when the player enters this trigger zone
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) // Ensure your player GameObject is tagged as "Player"
        {
            // Stop any currently playing audio
            audioSource.Stop();

            // Play the assigned audio clip
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
