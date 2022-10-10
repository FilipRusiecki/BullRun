using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{
    
    void Update()
    {
        if(transform.position.x<-4)
        {
            gameObject.transform.position = new Vector3(8.0f,transform.position.y,transform.position.z);
        }
    }
}
