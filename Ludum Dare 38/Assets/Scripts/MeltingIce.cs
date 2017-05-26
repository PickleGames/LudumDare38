using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltingIce : MonoBehaviour {

    //NEED AJUST
    private float timeElapsed;
	void Start () {
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
