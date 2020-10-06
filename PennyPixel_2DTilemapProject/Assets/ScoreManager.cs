using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static bool gameover;

    public Text scoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            scoreText.text = "You Win!\nYou collected " + score + " gems!";
        }
        else
        {
            scoreText.text = "Score: " + score;
        }
    }
}
