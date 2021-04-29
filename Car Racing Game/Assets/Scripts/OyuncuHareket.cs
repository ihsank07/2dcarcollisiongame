using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    Rigidbody2D rb2d;
    Vector2 velocity;
    float hiz;
    float hizlanma;
    float maksimumHiz;

    
    [SerializeField]
    GameObject patlamaPrefab = default;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        hiz = 2.0f;
        hizlanma = 1f;
        maksimumHiz = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        

        KlavyeKontrol();
        KamerayiHareketEttir();
        

    }
    void KlavyeKontrol()
    {
        float hareketInput = Input.GetAxisRaw("Horizontal");
        if (hareketInput > 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * 3.0f,10.0f * Time.deltaTime);

        }
        else if(hareketInput< 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * 3.0f, 10.0f * Time.deltaTime);
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, 10.0f * Time.deltaTime);
        }
        transform.Translate(velocity * Time.deltaTime);

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
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "platformaraba")
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            FindObjectOfType<OyunSonu>().OyunuBitir();

        }
    }

}
