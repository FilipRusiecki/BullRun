using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Score score;
    public GameObject doubleJumpPowerup;
    public Transform doubleJumpTrans;
    public Transform offScreenPos;
    public DoubleJump jump;
    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKeyDown(KeyCode.Escape)) // when escape is pressed the application is quit
        {
            Application.Quit();       
        }

        if(score.score == 500 || score.score == 1000 || score.score == 1500 || score.score == 2000 || score.score == 2500 || score.score == 3000 || score.score == 3500 || score.score == 4000 || score.score == 4500 || score.score == 5000 || score.score == 5500 || score.score == 6000 || score.score == 6500 || score.score == 7000 || score.score == 7500 || score.score == 8000 || score.score == 8500 )
        {
            Instantiate(doubleJumpPowerup, doubleJumpTrans.position, doubleJumpTrans.rotation);
        }

        if(jump.spawn == false)
        {
            doubleJumpPowerup.transform.position = new Vector3(offScreenPos.position.x, offScreenPos.position.y, offScreenPos.position.z);
        }
    }

}
