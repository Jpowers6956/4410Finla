using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RM4DoorCode : MonoBehaviour
{
    public GameObject[] blocks; // Array to hold references to the blocks
    public GameObject doorBlocker; // Reference to the door GameObject
    private string[] correctSequence = { "Green", "Red", "Blue" }; // Correct sequence of colors
    private int currentBlockIndex = 0; // Index of the current block being checked

    void Update()
    {
        // Check if the current block's color matches the expected color in the sequence
        if (blocks[currentBlockIndex].GetComponent<Renderer>().material.color == Color.green &&
            currentBlockIndex == 0)
        {
            currentBlockIndex++;
        }
        else if (blocks[currentBlockIndex].GetComponent<Renderer>().material.color == Color.red &&
                 currentBlockIndex == 1)
        {
            currentBlockIndex++;
        }
        else if (blocks[currentBlockIndex].GetComponent<Renderer>().material.color == Color.blue &&
                 currentBlockIndex == 2)
        {
            currentBlockIndex++;
        }

        // If the entire sequence is completed, unlock the door
        if (currentBlockIndex == 3)
        {
            Destroy(doorBlocker); // Or however you wish to unlock the door
            Debug.Log("Door unlocked!");
        }
    }
}
