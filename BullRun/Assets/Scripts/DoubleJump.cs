using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public bool spawn = true;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(spawn == true)
            {
                spawn = false;
                StartCoroutine(DoubleJumpCorout());
            }
        }
    }

    IEnumerator DoubleJumpCorout()
    {
        player.doubleJumpActive = true;

        yield return new WaitForSeconds(10.0f);

        player.doubleJumpActive = false;
    }
}
