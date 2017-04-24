using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltingIce : MonoBehaviour {

    //NEED AJUST
    public GameObject player;
    private float time;
    private float timeElapsed;

	void Start () {
        time = player.transform.GetChild(6).GetComponent<Score>().timer;
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
	    if(timeElapsed >= 5f)
        {
            Vector3 scale = this.transform.localScale;
            scale.x *= .90f;
            this.transform.localScale = scale;
            timeElapsed = 0;
        }	
	}
}
