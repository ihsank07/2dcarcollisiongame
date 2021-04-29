using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanHareket : MonoBehaviour
{
    float arkaplankonum;
    float mesafe = 9.93f;

    // Start is called before the first frame update
    void Start()
    {
        arkaplankonum = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
     if(arkaplankonum + mesafe<Camera.main.transform.position.y)
        {
            ArkaPlanYerlestir();
        }  
    }
    void ArkaPlanYerlestir()
    {
        arkaplankonum += (mesafe * 2);
        Vector2 yeniPozisyon = new Vector2(0, arkaplankonum);
        transform.position = yeniPozisyon;

    }

}
