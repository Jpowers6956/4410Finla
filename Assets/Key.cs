using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Reference to the key sprite
    public GameObject keySprite;
    public GameObject keyInventory;

    // Method to be called when the player collides with the key
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            PickupKey();
        }
    }

    // Method to pick up the key
    void PickupKey(){
        // Disable the key sprite
        keySprite.SetActive(false);
        keyInventory.SetActive(true);

        // Optionally, you can also play a sound effect or animation here
    }
}
