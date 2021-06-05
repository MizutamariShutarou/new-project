using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{ 

    public int initScore;
    int currentScore;
    Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
       currentScore =  initScore;
       ScoreText = this.GetComponent<Text>();
       PrintScore(initScore);
    }

    public void addScore(int n)
    {
        currentScore += n;
        PrintScore(currentScore);
    }



    // Update is called once per frame
    void PrintScore(int n)
    {
        ScoreText.text = n.ToString();
    }
}
