using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public Text scoreText;
    public static int score;

    public Text timerText;
    public float timer; 

    private AudioSource audioSource;

    public AudioClip[] sealSounds;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(scoreText);
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        timerText.text = "Time Left: " + timer.ToString();

        audioSource = GetComponent<AudioSource>();
	}

    float timeELapsed;
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + score.ToString();
        timerText.text = "Time Left: " + timer.ToString();

        timeELapsed += Time.deltaTime;

        if (timeELapsed > 1f)
        {
            timer--;
            timeELapsed = 0;
        }

        if (timer< 0)
        {
            SceneManager.LoadScene("EndScene");
        }
           

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        Debug.Log("WE HAVE COLLIDED!!!");

        int rand = Random.Range(0,sealSounds.Length);
        if (go.CompareTag("enemy"))
        {
            Debug.Log("INCREMENTING SCORE!!");
            score += 1;
            PlaySound(rand);
        }
    }

    void PlaySound(int clip)
    {
       audioSource.clip = sealSounds[clip];
        audioSource.Play();
    }
}
