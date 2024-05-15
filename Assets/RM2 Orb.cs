using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RM2Orb : MonoBehaviour
{
    public GameObject largeScoreObject;
    [SerializeField] Text scoreLabel;

    public GameObject doorBlocker;
    private int score;


    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            score++;
            scoreLabel.text = score.ToString();
            Destroy(this.gameObject);
            Destroy(doorBlocker);
        }
    }
}
