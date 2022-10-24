using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

  
    public GameObject m_Bull;
    public GameObject m_particle;
    public GameObject m_Bird;
    public GameObject m_crate;
    public GameObject m_cactus;
    public GameObject m_shrapnel;
    public Transform m_pos;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bull"))
        {
            GameObject particle = Instantiate(m_particle, m_pos);
            Debug.Log("collidede with bull");
            GetComponent<Health>().depricateHealth();
            Destroy(particle, 2.0f);
        }
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shrapnel"))
        {
           
           
            GetComponent<Player>().pushback();
            GetComponent<Health>().depricateHealth();
            Debug.Log("collidede with Shrapnel");
            Destroy(m_shrapnel.gameObject, 0.5f);

        }

        if (collision.gameObject.CompareTag("cactus"))
        {

            GetComponent<Player>().pushback();
            m_cactus.GetComponent<cactus>().respawn();
            Debug.Log("collidede with cactus");
           

        }

       
        if (collision.gameObject.CompareTag("bird"))
        {

            GetComponent<Player>().pushback();
            m_Bird.GetComponent<bird>().respawn();
            Debug.Log("collidede with bird");

        }

        if (collision.gameObject.CompareTag("barrel"))
        {
            GetComponent<Player>().pushback();
            m_crate.GetComponent<crate>().respawn();
            Debug.Log("collided with barrell");   
        }

    }
}
