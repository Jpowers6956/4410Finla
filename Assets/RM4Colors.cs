using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RM4Colors : MonoBehaviour
{
    public GameObject colorChanger;
    public GameObject trigger;
    private List<Color> colors = new List<Color>() {Color.red, Color.blue, Color.green};
    private int currentColorIndex = 0;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            Input.GetKeyDown(KeyCode.C);
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.CompareTag("Player"))
        {
            Input.GetKeyUp(KeyCode.C);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && IsInsideTriggerZone()){
            ChangeColor();
        }
    }

    bool IsInsideTriggerZone(){
        // Get the center of the trigger's collider
        Vector2 triggerCenter = trigger.transform.position;

        // Define the radius of the circle. Adjust this value based on your trigger size.
        float radius = trigger.GetComponent<CircleCollider2D>().radius;

        // Check if the player's collider overlaps with the trigger's collider
        Collider2D hit = Physics2D.OverlapCircle(triggerCenter, radius);

        // Return true if the player is inside the trigger zone, false otherwise
        return hit!= null && hit.gameObject.CompareTag("Player");
    }


    void ChangeColor(){
        colorChanger.GetComponent<Renderer>().material.color = colors[currentColorIndex];
        currentColorIndex = (currentColorIndex + 1) % colors.Count;
    }
}
