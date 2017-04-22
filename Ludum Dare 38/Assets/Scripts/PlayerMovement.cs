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
    private GameObject seal;
    private GameObject sealTail;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        seal = this.gameObject.transform.GetChild(0).gameObject;
        sealTail = this.gameObject.transform.GetChild(3).gameObject;
    }

    private void FixedUpdate()
    {
        // check if doge is on ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        // get WASD/ARROW input and move doge accordingly
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }

    bool directionLeft = true;
    bool isFlip = false; 
    // Update is called once per frame
    void Update () {

        if (grounded && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            if (rb.velocity.x > 0 && directionLeft)
            {
                Flip();
                directionLeft = false;
            }
            

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rb.velocity.x < 0 && !directionLeft)
            {
                Flip();
                directionLeft = true;
            }
        }
            

    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
