using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EdgeScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
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
            Debug.Log("PLAYER HAS HIT THE EDGE. REPEAT. PLAYER HIT EDGE");
            SceneManager.LoadScene("EndScene");
        }
    }
}
