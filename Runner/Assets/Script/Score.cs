using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0.0f;
    public Text scoreText;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;


    void Update()
    {
    
        if (score >= scoreToNextLevel)
            LevelUp();
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
        
    }

    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;
        scoreToNextLevel *= 2;
        difficultyLevel++;
        GetComponent<PlayerMovement>().SetSpeed(difficultyLevel);
    }


    
}
