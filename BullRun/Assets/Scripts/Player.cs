using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public Health health;
    public GameObject text;
    [Header("Player Jumping")]
    public float jumpForce = 0;
    public int jumpCount = 0;
    public int allowedJumps = 0;
    public float gravityScale = 0;
    public float fallingGravityScale = 0;
    public bool isGrounded = false;
    public Animator animator;

    public bool doubleJumpActive = false;

    int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text.gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health >= 0)
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
        else if (health.health < 0)
        {
            text.gameObject.active = true;

        
            if (Input.GetKeyDown(KeyCode.R))
            {
               
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
         
            
        }


        //////////Double Jump Active stuff///////////////
        if (doubleJumpActive == true)
        {
            allowedJumps = 2;
        }
        else if (doubleJumpActive == false)
        {
            allowedJumps = 1;
        }

            
    }

    public void pushback()
    {
        rb.AddForce(Vector2.left*3.0f, ForceMode2D.Impulse);
    }
}
