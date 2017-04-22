using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour {

    private List<GameObject> seals;

    public GameObject seal;
    
	// Use this for initialization
	void Start () {

        seals = new List<GameObject>();
	}


    float delay;
	// Update is called once per frame
	void Update () {
		
	}

    void spawnSeals()
    {
        int rand = Random.Range(0,1);

        if(rand > 0)
        {
            GameObject g = (GameObject) Instantiate(seal, new Vector3(20,-10,0), Quaternion.Euler(0, 0, 0));
        }else
        {
            GameObject g = (GameObject)Instantiate(seal, new Vector3(-20, -10, 0), Quaternion.Euler(0, 0, 0));
        }
            
    }
}
