using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    float move;
    public float jumpForce;

    // ground check variables
    bool grounded;
    public Transform groundCheck;
    float groundRadius = .25f;
    public LayerMask whatIsGround;

    private Transform myTransform;

    private GameObject seal;

    private Animator animator;
   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
        seal = this.gameObject.transform.GetChild(0).gameObject;

        animator = GetComponent<Animator>();
        
    }

    private void FixedUpdate()
    {
        // check if doge is on ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        // get WASD/ARROW input and move doge accordingly
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update () {

        if (grounded && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }

        if (rb.velocity.x > 0)
        {
           seal.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            seal.GetComponent<SpriteRenderer>().flipX = false;
        }

        animator.SetFloat("Speed", rb.velocity.x);
        animator.SetBool("Ground", grounded);

    }
}
