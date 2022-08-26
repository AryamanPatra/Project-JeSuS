using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;
    public Text distance;

    private int score = 0;
    private int highscore = 0;
    private double distanceNum=0.0;

    private void Awake(){
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = " SCORE:"+score;
        highscoreText.text = " Highscore:" + highscore; 
    }

    private void FixedUpdate()
    {
        distance.text = "Distance: "+Math.Round(distanceNum,2)+" km";
        distanceNum += 0.004;
    }

    public void AddPoint(int points)
    {
        score+=points;
        scoreText.text = " SCORE:"+score;
        if (score > highscore)
            PlayerPrefs.SetInt("highscore",score);
    }

}
