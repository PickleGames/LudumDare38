using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

    public Text scoreText;
    private int score;

    public Text endText;




    // Use this for initialization
    void Start () {
        endText.text = "This is the end for you! Seal you later!";
        score = Score.score;
        scoreText.text = "Score: " + score.ToString();

       
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score.ToString();
    }

    public void RetryButtonFunction()
    {
        SceneManager.LoadScene("Miguel");
    }

    public void QuitButtonFunction()
    {
        Application.Quit();
    }
 
}
