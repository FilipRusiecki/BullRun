using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
 
    public GameObject bird;
    public GameObject crate;
    public GameObject cactus;
    public Score score;
    private bool spawned = false;
    private bool secondSpawn = false;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int score1 = score.score;
      

        if (score1 > 100&&spawned==false)
        {
            Instantiate(bird, new Vector3(bird.transform.position.x+6.0f, 0, 0), Quaternion.identity);
            spawned = true;
            Debug.Log("created bird");
          
        }
        if (score1 > 400&&secondSpawn==false)
        {
            Instantiate(cactus, new Vector3(cactus.transform.position.x + 9.0f, cactus.transform.position.y, 0), Quaternion.identity);
            Instantiate(crate, new Vector3(crate.transform.position.x + 9.0f, crate.transform.position.y, 0), Quaternion.identity);
            Instantiate(bird, new Vector3(bird.transform.position.x + 9.0f,0, 0), Quaternion.identity);
            secondSpawn = true;
        }

    }
}
