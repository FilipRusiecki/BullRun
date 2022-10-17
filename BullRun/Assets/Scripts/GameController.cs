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


    public GameObject tictac;
    public Transform pos;
    public Transform pos2;
    public NoDamageUpgrade noDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    } 

    private void FixedUpdate()
    {
        if (score.score == 500 || score.score == 1000 || score.score == 1500 || score.score == 2000 || score.score == 2500 || score.score == 3000 || score.score == 5000 || score.score == 10000 || score.score == 20000)
        {
            tictac.transform.position = new Vector3(pos.position.x,pos.position.y,pos.position.z);
        }

        if (noDamage.spawn == false)
        {
            tictac.transform.position = new Vector3(pos2.position.x, pos2.position.y, pos2.position.z);
        }
		
		
        if(score.score == 500 || score.score == 1000 || score.score == 1500 || score.score == 2000 || score.score == 2500 || score.score == 3000 || score.score == 3500 || score.score == 4000 || score.score == 4500 || score.score == 5000 || score.score == 5500 || score.score == 6000 || score.score == 6500 || score.score == 7000 || score.score == 7500 || score.score == 8000 || score.score == 8500 )
        {
            Instantiate(doubleJumpPowerup, doubleJumpTrans.position, doubleJumpTrans.rotation);
        }

        if(jump.spawn == false)
        {
            doubleJumpPowerup.transform.position = new Vector3(offScreenPos.position.x, offScreenPos.position.y, offScreenPos.position.z);
        }
		
		if(Input.GetKeyDown(KeyCode.Escape)) // when escape is pressed the application is quit
        {
            Application.Quit();       
        }
    }
}
