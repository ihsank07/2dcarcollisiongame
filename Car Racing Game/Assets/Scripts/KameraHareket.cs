using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maksimumHiz;

    bool hareket=true;

    // Start is called before the first frame update
    void Start()
    {
        hiz = 2f;
        hizlanma = 1f;
        maksimumHiz = 50f;

    }

    // Update is called once per frame
    void Update()
    {
        if (hareket) 
        {
            KamerayiHareketEttir();
        }
       

        
    }
    void KamerayiHareketEttir()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if (hiz > maksimumHiz)
        {
            hiz = maksimumHiz;


        }
    }
}
