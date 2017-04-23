using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSlamScript : MonoBehaviour {

    public Skill skill;

    public GameObject player;
    private bool isJump;
    private float timeElapsed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (skill.IsUse && !isJump)
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 500);
            isJump = true;
        }

        if (skill.IsUse && player.GetComponent<PlayerMovement>().grounded)
        {
            timeElapsed += Time.deltaTime;
        }

        if (!skill.IsUse)
        {
            isJump = false;
        }

        Debug.Log("ground " + player.GetComponent<PlayerMovement>().grounded);
        Debug.Log("time :" + timeElapsed);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (skill.IsUse) {
            Debug.Log("slam use");
            if (timeElapsed < 1f && player.GetComponent<PlayerMovement>().grounded)
            {
                Debug.Log("Slam");
                GameObject go = col.gameObject;
                Debug.Log("is enemey : " + go.CompareTag("enemy"));
                if (go.CompareTag("enemy"))
                {
                    float strength = skill.strength;
                    Debug.Log("strength =" + strength);
                    Vector3 dir = GetComponent<Transform>().position - go.transform.position;
                    dir.Normalize();
                    dir = -dir;
                    go.GetComponent<Rigidbody2D>().AddForce(dir * strength);
                }
            }
            
        }
    }
}
