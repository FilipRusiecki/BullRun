using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

  
    public GameObject m_Bull;
    public GameObject m_particle;
    public Transform m_pos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bull"))
        {
            GameObject particle = Instantiate(m_particle, m_pos);
            Debug.Log("collidede with bull");
            Destroy(particle,2.0f);
        }


        if (collision.gameObject.CompareTag("cactus"))
        {

            GetComponent<Player>().pushback();
            Debug.Log("collidede with cactus");
           
        }

        if (collision.gameObject.CompareTag("barrel"))
        {
            GetComponent<Player>().pushback();
            Debug.Log("collidede with barrell");
           
        }

    }
}
