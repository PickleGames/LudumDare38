using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + score.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        Debug.Log("WE HAVE COLLIDED!!!");
        if (go.CompareTag("enemy"))
        {
            Debug.Log("INCREMENTING SCORE!!");
            score += 1;
        }
    }
}
