using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float speed = 3.0f;
    Rigidbody rb;

    public GameObject Coin;



    public GameObject Left;
    public GameObject Right;
    float LeftPositionX;
    float RightPositionX;

    public GameObject ScoreText;
    Score ScoreS;


   //Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        LeftPositionX = Left.transform.position.x;
        RightPositionX = Right.transform.position.x;

        ScoreS = ScoreText.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.transform.position;

        currentPosition.x = Mathf.Clamp(currentPosition.x,
                                        LeftPositionX,
                                        RightPositionX);

        this.transform.position = currentPosition;




        float x = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(x, 0, 0);



        rb.velocity = direction * speed;

        if (Input.GetKeyDown("space")){

            Instantiate(Coin, this.transform.position, this.transform.rotation);

        }
    }
}
