using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = score.ToString() + " KILLS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString(); 
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString() + " KILLS";
        if (score > highscore)
            PlayerPrefs.SetInt("highscore",score);
    }

    private void Awake(){
        instance = this;
    }
}
