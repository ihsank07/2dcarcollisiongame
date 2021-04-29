
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField]
    GameObject platformPrefab = default;
    [SerializeField]
    GameObject platformPrefab2 = default;
    [SerializeField]
    GameObject platformPrefab3 = default;
    [SerializeField]
    GameObject platformPrefab4 = default;
    [SerializeField]
    GameObject platformPrefab5 = default;
    [SerializeField]
    GameObject platformPrefab6 = default;
    [SerializeField]
    GameObject platformPrefab7 = default;


    List<GameObject> platforms = new List<GameObject>();

    List<GameObject> arabaListesi = new List<GameObject>();
    

    Vector2 platformPozisyon;

    [SerializeField]
    float platformArasiMesafe = default;


    // Start is called before the first frame update
    void Start()
    {
        
        arabaListesi.Add(platformPrefab);
        arabaListesi.Add(platformPrefab2);
        arabaListesi.Add(platformPrefab3);
        arabaListesi.Add(platformPrefab4);
        arabaListesi.Add(platformPrefab5);
        arabaListesi.Add(platformPrefab6);
        arabaListesi.Add(platformPrefab7);
        PlatformUret();
    }

    // Update is called once per frame
    void Update()
    {
        if (platforms[platforms.Count - 1].transform.position.y <
            Camera.main.transform.position.y + EkranHesaplayicisi.instance.Yukseklik)
        {

            PlatformYerlestir();

        }


    }
    void PlatformUret()
    {
        platformPozisyon = new Vector2(0, 0);
        for (int i = 0; i < 10; i++)
        {

            int prefabIndex = Random.Range(0, arabaListesi.Count);
            GameObject platform = Instantiate(arabaListesi[prefabIndex], platformPozisyon, Quaternion.identity);
            platforms.Add(platform);



            platform.GetComponent<Platform>().Hareket = true;
           
            SonrakiPlatformPozisyon();
            
        }

    }

     void PlatformYerlestir()
     {
         for (int i = 0; i < 7; i++)
         {
         GameObject temp;
         temp = platforms[i + 7];
         platforms[i + 7] = platforms[i];
         platforms[i] = temp;
         platforms[i + 7].transform.position = platformPozisyon;

            SonrakiPlatformPozisyon();

        }


     }
    //farklıkonumlar içi
    void SonrakiPlatformPozisyon()
        {
             platformPozisyon.y += platformArasiMesafe;

            float random = Random.Range(0.0f, 1.0f);
            if (random < 0.5f)
            {
                platformPozisyon.x = EkranHesaplayicisi.instance.Genislik / 2;

            }
            else
            {
                platformPozisyon.x = -EkranHesaplayicisi.instance.Genislik / 2;

            }

        }
    void PlatformKaristir()
    {
    
    }
}

