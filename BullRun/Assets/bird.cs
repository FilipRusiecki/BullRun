using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -5.5)
        {
            gameObject.transform.position = new Vector3(8.0f, Random.RandomRange(0.5f,1.2f), transform.position.z);
        }
    }
}
