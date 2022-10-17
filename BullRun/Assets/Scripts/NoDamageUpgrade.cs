using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDamageUpgrade : MonoBehaviour
{
    public Health health;
    public bool spawn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {   if (spawn == true)
            {
                spawn = false;  
                StartCoroutine(NoDamage());
            }
        }
    }

    IEnumerator NoDamage()
    {
      
        health.allowDamage = false;
        yield return new WaitForSeconds(5.0f);
        health.allowDamage = true;
        spawn = true;
    }
}
