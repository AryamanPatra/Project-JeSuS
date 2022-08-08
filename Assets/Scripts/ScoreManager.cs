using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

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

    public void AddPoint(int points)
    {
        score+=points;
        scoreText.text = " SCORE:"+score;
        if (score > highscore)
            PlayerPrefs.SetInt("highscore",score);
    }

}
