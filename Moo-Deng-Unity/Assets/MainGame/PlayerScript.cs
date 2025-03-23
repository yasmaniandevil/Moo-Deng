using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 5f;
    public int jumpForce = 4;
    public int gravityForce = 5;
    public bool isjumpToggleEnabled = true;
    private Transform playerTransform;

    private bool isGrounded = true;

    private bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb2d.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);

        if (Input.GetKey(KeyCode.Space) && isjumpToggleEnabled)
        {
            //apply upward force to the rigidbody for the jump
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            Debug.Log("Jump");

        }

        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(1);
        }

        if(horizontalInput < 0)
        {
            Debug.Log("pressing a");
        }

        

        
    }

    void Jump()
    {
        if (isGrounded)
        {
           
        }
        //apply upward force to the rigidbody for the jump
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
    }

    void Flip()
    {
        

        isFacingRight = !isFacingRight;
        Quaternion theRot = transform.localRotation;
        theRot.y = 180f;
        transform.localRotation = theRot;

    }
}
