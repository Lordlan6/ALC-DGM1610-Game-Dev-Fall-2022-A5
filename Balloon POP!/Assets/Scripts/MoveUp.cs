using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float uppperBound = 50.0f;
    private Balloon balloon;

    public ScoreManager scoreManager;

    
        // Start is called before the first frame update
        void Start()
        {
            scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
            balloon = GetComponent<Balloon>();
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
            if(transform.position.y > uppperBound) //destroy balloon if it reaches max height
            {
                scoreManager.DecreaseScoreText(balloon.scoreToGive);// subtract scoreToGive from total score
                Destroy(gameObject);
            }
        }
    
}