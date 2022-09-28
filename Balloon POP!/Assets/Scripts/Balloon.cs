using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;
    public int clickToPop = 3;
    public float scaleToIncrease = 0.10f;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void OnMouseDown()
    {
        clickToPop -= 1;

        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
