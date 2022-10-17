using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactus : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x < -6)
        {
            gameObject.transform.position = new Vector3(15.0f, transform.position.y, transform.position.z);
        }
    }
    public void respawn()
    {
        gameObject.transform.position = new Vector3(15.0f, transform.position.y, transform.position.z);
    }
}
