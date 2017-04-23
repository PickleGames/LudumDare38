using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    public float jumpForce;

    float jumpDelay;
    float directionDelay;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

        jumpDelay = Random.Range(1,3);
        directionDelay = Random.Range(1,3);
	}

    float time;
    float timer2;
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (time > directionDelay)
        {
            speed *= -1;
            rb.velocity = new Vector2(speed, rb.velocity.y);
            time = 0;
        }
        if (timer2 > jumpDelay)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            timer2 = 0;
        }
       
	}

}
