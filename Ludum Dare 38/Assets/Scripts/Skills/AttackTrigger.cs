using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackTrigger : MonoBehaviour {

    public Skill skill;

    public GameObject player;

	void Start () {
  
    }
	
	// Update is called once per frame
	void Update () {

        if (skill.IsUse && skill.GetType() == typeof(RoundAboutSlap) )
        {
            if(skill.TimeCoolDown < 3)
            { 
                player.GetComponent<PlayerMovement>().Flip();
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("push");
        GameObject go = col.gameObject;
        if (go.CompareTag("enemy"))
        {
            float strength = skill.strength; 
            Debug.Log("strength ="  + strength);
            Vector3 dir = GetComponent<Transform>().position - go.transform.position;
            dir.Normalize();
            dir = -dir;
            go.GetComponent<Rigidbody2D>().AddForce(dir * strength);

        }
    }
}
