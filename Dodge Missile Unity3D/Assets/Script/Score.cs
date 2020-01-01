using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text TScore;
    int score = 0;
    float timer = 0;
    private string Fscore;

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            Fscore = TScore.text;
            score += 2;
            TScore.text = "SCORES : " + score.ToString();

            timer = 0;
            
        }
        
    }

    
}
