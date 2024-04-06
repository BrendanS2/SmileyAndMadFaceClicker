using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreasePoints : MonoBehaviour
{


    public int score = 0;
    public Text scoreText;
    public int multiplyer = 1;

    public void AddPoints()
    {
        score = score + multiplyer;
        Debug.Log(score);

    }


    public void Add2Points()
    {
        if (score >= 20)
        {
            score = score - 20;
            multiplyer = multiplyer + 1;
        }
    }




    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score: ") +score.ToString();
    }
}
