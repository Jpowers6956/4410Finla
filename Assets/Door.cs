using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject keySprite;
    public GameObject doorBlocker;
    public GameObject keyInventory;

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player") && !keySprite.activeSelf){
                Destroy(doorBlocker);
                keyInventory.SetActive(false);                
        }

    }

}
