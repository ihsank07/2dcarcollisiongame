
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    bool hareket = true;

    float min, max;
    float randomHiz;


    public bool Hareket
    {
        get
        {
            return hareket;
        }
        set
        {
            hareket = value;

        }
    }

    // Start is called before the first frame update
     void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        randomHiz = Random.Range(0.2f, 3.0f);

        float objeGenislik = boxCollider2D.bounds.size.x / 2;

        if (transform.position.x > 0)
        {
            min = objeGenislik;

            max = EkranHesaplayicisi.instance.Genislik - objeGenislik;
         

        }
        else
        {
            

            min = -EkranHesaplayicisi.instance.Genislik + objeGenislik;
            max = -objeGenislik;

           
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        if(Hareket==true)
        {
            float pingPongX = Mathf.PingPong(Time.time * randomHiz, max - min) + min;
            Vector2 pingPong = new Vector2(pingPongX, transform.position.y);
            transform.position = pingPong;


        }
    }

}
