using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_manager : MonoBehaviour
{
    public int score=0;
    public Text Score;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        Score.text = "Score= " + score.ToString();

    }

    void OnTriggerEnter2D(Collider2D other)               //if collision then increase score
    {
        
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log("score: " + score);

        }
    }
}
