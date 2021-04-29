using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Muzik();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OyunuBaslat()
    {
        SceneManager.LoadScene("Oyun");
        

    }
    public void Muzik()
    {
        //geri dönülecek buraya
        MuzikKontrol.instance.MuzikCal(true);
        
    
    }




}
