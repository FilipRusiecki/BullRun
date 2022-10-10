using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    [Header("Player Jumping")]
    public float jumpForce = 0;
    public int jumpCount = 0;
    public int allowedJumps = 0;
    public float gravityScale = 0;
    public float fallingGravityScale = 0;
    public bool isGrounded = false;
    public Animator animator;

    int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("isGrounded", false);
            jumpCount += 1;
            if (jumpCount == allowedJumps)
            {
                isGrounded = false;
            }


        }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;

            }
    }
}
