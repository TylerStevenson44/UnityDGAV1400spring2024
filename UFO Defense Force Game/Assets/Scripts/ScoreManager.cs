using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // added TMP namespace so we can acces the unity library for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // our score value
    public TextMeshProUGUI scoreText; // The Visual text element to be modified

    public void IncreaseScore(int amount) // the method called so we can increase the score
    {

        score += amount;
        UpdateScoreText();
    }
    public void DecreaseScore(int amount) // the method called so we can decrease the score
    {
        score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText() // used to update the text within the UI
    {
        scoreText.text = "Score: " + score;
    }
}