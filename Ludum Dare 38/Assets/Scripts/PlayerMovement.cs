using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    float move;
    public float jumpForce;

    // ground check variables
    public bool grounded;
    public Transform groundCheck;
    float groundRadius = .25f;
    public LayerMask whatIsGround;
    private GameObject seal;

    private Animator animator;

   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        seal = this.gameObject.transform.GetChild(0).gameObject;

        animator = GetComponent<Animator>();

    }

    private void FixedUpdate()
    {
        // check if seal is on ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        // get WASD/ARROW input and move doge accordingly
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }

    bool directionLeft = true;
    bool isFlip = false; 
    // Update is called once per frame
    void Update () {

        if (grounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.x > 0 && directionLeft)
            {
                Flip();
                directionLeft = transform.localScale.x != -1;
            }

        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.x < 0 && !directionLeft)
            {
                Flip();
                directionLeft = transform.localScale.x != -1;
            }
        }


        animator.SetFloat("Speed", rb.velocity.x);
        animator.SetBool("Ground", grounded);

    }

    public void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
