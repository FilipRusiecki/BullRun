using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public GameObject tictac;
    public Score score;
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
    }
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape)) // when escape is pressed the application is quit
        {
            Application.Quit();       
        }
    }

}
