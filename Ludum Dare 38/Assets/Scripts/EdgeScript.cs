using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EdgeScript : MonoBehaviour {

    private AudioSource audioSource;

    public AudioClip sound;

    public static bool dead = false;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sound;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;

        if (go.CompareTag("enemy"))
        {
            DestroyObject(go);
        }

        Debug.Log("YOU HAVE HIT THE EDGE");
        if (go.CompareTag("SEAL"))
        {
            audioSource.Play();
            dead = true;          
            Debug.Log("PLAYER HAS HIT THE EDGE. REPEAT. PLAYER HIT EDGE");
          
           SceneManager.LoadScene("EndScene");        
          
        }
    }
}
