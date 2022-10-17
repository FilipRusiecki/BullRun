using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    private int temp;
    private TMP_Text scoreText;
    public Health health;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health >= 0)
        {
            scoreText.text = "Score: " + score.ToString();
            temp++;
            if (temp >= 60)
            {
                temp = 0;

                score += 10;
            }
        }
    }
}
