using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -10.0f)
        {
            gameObject.transform.position = new Vector3(10.0f, Random.RandomRange(0.5f,1.2f), transform.position.z);
        }
    }

    public void respawn()
    {
        gameObject.transform.position = new Vector3(10.0f, transform.position.y, transform.position.z);
    }
}
