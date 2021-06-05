using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Saucer : MonoBehaviour
{
    public GameObject ScoreText;
    Score ScoreS;

    AudioSource getSE;


    private void Start()
    {
        ScoreS = ScoreText.GetComponent<Score>();
        getSE = this.GetComponent<AudioSource>();
        
    }




    private void  OnCollisionEnter(Collision collision)
    {
        

        if(collision.gameObject.tag == "Coin")
        {
            getSE.Play();
            ScoreS.addScore(1);
            Destroy(collision.gameObject);
          
        }
    }
}
