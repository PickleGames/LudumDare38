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

    public Text slappoText;

    private AudioSource audioSource;

    public AudioClip[] sealSounds;

    public Text shouting;
    public string[] words;
    public Transform player;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(scoreText);
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        timerText.text = "Time Left: " + timer.ToString();
        slappoText.text = "SLAP THOSE FILTHY PEASANTS!!!";

        audioSource = GetComponent<AudioSource>();
	}

    float timeELapsed;
    float timeElap;

    float slappoGoAway;
    // Update is called once per frame
    void Update() {

        scoreText.text = "Score: " + score.ToString();
        timerText.text = "Time Left: " + timer.ToString();

        timeELapsed += Time.deltaTime;
        slappoGoAway += Time.deltaTime;

        if (slappoGoAway > 5f)
        {
            slappoText.enabled = false;
        }


        if (timeELapsed > 1f)
        {
            timer--;
            timeELapsed = 0;
        }

        if (timer< 0)
        {
            SceneManager.LoadScene("EndScene");
        }

        shouting.transform.position = new Vector3(player.position.x, player.position.y + 1, player.position.z);

        if (shouting.enabled)
        {
            timeElap += Time.deltaTime;
            if (timeElap > .75f)
            {
                shouting.enabled = false;
                timeElap = 0;
            }

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
            shouting.enabled = true;
            int randor = Random.Range(0,words.Length);
            shouting.text = words[randor];
        }

    }

    void PlaySound(int clip)
    {
       audioSource.clip = sealSounds[clip];
        audioSource.Play();
    }
}
