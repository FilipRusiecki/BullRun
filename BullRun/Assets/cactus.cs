using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactus : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x < -3.5)
        {
            gameObject.transform.position = new Vector3(4.0f, transform.position.y, transform.position.z);
        }
    }
}
