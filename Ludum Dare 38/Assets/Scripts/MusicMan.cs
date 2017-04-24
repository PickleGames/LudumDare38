using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMan : MonoBehaviour {
    private AudioSource audioSource;

    public AudioClip[] music;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();

        int rand = Random.Range(0,music.Length);

        audioSource.clip = music[rand];
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
