using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour {

    private List<GameObject> aiSeals;

    public GameObject seal;
    
	// Use this for initialization
	void Start () {

        aiSeals = new List<GameObject>();
	}


    float delay;
	// Update is called once per frame
	void Update () {
        spawnSeals();
	}

    void spawnSeals()
    {
        int rand = Random.Range(0,1);

        if(rand > 0)
        {
            GameObject g = Instantiate(seal, new Vector3(0, -0, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
        }else
        {
            GameObject g = Instantiate(seal, new Vector3(-0, -0, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
        }
            
    }
}
