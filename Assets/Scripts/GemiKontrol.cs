using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject kursunPrefab = default;


    [SerializeField]
    GameObject patlamaPrefab = default;


    OyunKontrol oyunKontrol;

    const float hareketGucu = 5;

    
    // Start is called before the first frame update
    void Start()
    {
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal"); // Unity'de "Horizontal" doðru girdi ismi

        if (yatayInput != 0) // != operatörü arasýndaki boþluklar kaldýrýldý
        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }

        float dikeyInput = Input.GetAxis("Vertical"); // Unity'de "Vertical" doðru girdi ismi
        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }

        transform.position = position;

        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
            Vector3 kursunpozisyon = gameObject.transform.position;
            kursunpozisyon.y += 1;
            Instantiate(kursunPrefab, kursunpozisyon, Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().GemiPatlama();
            oyunKontrol.OyunuBitir();
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
