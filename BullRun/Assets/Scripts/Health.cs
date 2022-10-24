using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    [SerializeField]
    private float invincibleSeconds = 2.0f;

    public bool allowDamage = true;
    // Update is called once per frame
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    public void depricateHealth()
    {
        if (!allowDamage) return;
        
        health--;
        Debug.Log("takeAwayLife");

        StartCoroutine(Invincible());
    }

    public void depricateHealth(int minusHealth)
    {
        if (!allowDamage) return;

        health -= minusHealth;
        Debug.Log("takeAwayLife");

        StartCoroutine(Invincible());
    }

    private IEnumerator Invincible()
    {
        allowDamage = false;
        yield return new WaitForSeconds(invincibleSeconds);
        allowDamage = true;
    }
}
