using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFloor : MonoBehaviour
{
    public BoxCollider2D collider;

    int speed = 7;
    float width;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        width = collider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -18)
        {
            Vector3 resetPos = new Vector3(36, 0, 0);

            transform.position += resetPos;
        }
    }
}
