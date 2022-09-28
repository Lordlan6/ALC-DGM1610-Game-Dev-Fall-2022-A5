using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep track of the score
    public TextMeshProUGUI scoreText; // test UI object to be modified
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }
    public void IncreaseScoreText(int amount)
    {
        score += amount; // increase score by amount
        UpdateScoreText();
    }
    public void DecreaseScoreText(int amount)
    {
        score -= amount; // decrease score by amount
        UpdateScoreText();
    }
    // Update is called once per frame
    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
