using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketballScoreManager : MonoBehaviour
{
    public static BasketballScoreManager instance; 

    //Variables
    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score >= 6)
        {
            scoreText.text = "You Win!";   
        }
    }
}
