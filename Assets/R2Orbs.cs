using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class R2Orbs : MonoBehaviour
{
    [SerializeField] TMP_Text scoreLabel;
    public GameObject scoreSprite;
    

    private int score = 0;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            score += 10;
            scoreLabel.text = score.ToString();
            Destroy(this.gameObject);
        }
    }
}
