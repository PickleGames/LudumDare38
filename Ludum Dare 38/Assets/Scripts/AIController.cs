using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    public float jumpForce;

    float jumpDelay;
    float directionDelay;
    //public GameObject target;
    // ground check variables
    bool grounded;
    public Transform groundCheck;
    float groundRadius = 0.5f;
    public LayerMask whatIsGround;

    private AudioSource audioSource;

    public AudioClip[] sealSounds;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        groundRadius = rb.transform.localScale.x + 1;

        jumpDelay = Random.Range(1,3);
        directionDelay = Random.Range(1,3);

        audioSource = GetComponent<AudioSource>();
	}

    float time;
    float timer2;
    float arfTimer;
	// Update is called once per frame
	void Update () {

        // check if seal is on ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        time += Time.deltaTime;
        timer2 += Time.deltaTime;
        arfTimer += Time.deltaTime;

        if (time > directionDelay)
        {
            Vector2 dir = (transform.position - new Vector3(0, 0, 0)).normalized;
            rb.velocity = new Vector2(-dir.x * speed, rb.velocity.y);
            time = 0;
        }
            
        if (timer2 > jumpDelay && grounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            timer2 = 0;
        }

        if (arfTimer > Random.Range(1,8))
        {
            int rand = Random.Range(0, sealSounds.Length);
            audioSource.clip = sealSounds[rand];
            audioSource.Play();
            arfTimer = 0;
        }
        

    }

}
