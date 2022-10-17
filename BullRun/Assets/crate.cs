using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x < -5.5)
        {
            gameObject.transform.position = new Vector3(11.0f, transform.position.y, transform.position.z);
        }
    }

    public void respawn()
    {
        gameObject.transform.position = new Vector3(11.0f, transform.position.y, transform.position.z);
    }
}
