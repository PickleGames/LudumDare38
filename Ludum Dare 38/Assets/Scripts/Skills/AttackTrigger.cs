using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour {

    public Skill skill;
    public GameObject player;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("push");
        GameObject go = col.gameObject;
        if (go.CompareTag("enemy"))
        {
            float strength = ((Slap)(skill)).strength;
            Vector3 dir = GetComponent<Transform>().position - go.transform.position;
            dir.Normalize();
            dir = -dir;
            go.GetComponent<Rigidbody2D>().AddForce(dir * strength);
        }
    }
}
