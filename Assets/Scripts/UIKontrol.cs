using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject oynaButon = default;

    [SerializeField]
    GameObject oyunAdiText = default;

    [SerializeField]
    GameObject oyunBittiText = default;

    [SerializeField]
    Text puanText = default;

    int puan = 0;


    // Start is called before the first frame update
    void Start()
    {

        oyunBittiText.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);
    }


    public void OyunBasladi() 
    { 
        puan = 0;
        oyunAdiText.gameObject.SetActive(false);
        oynaButon.gameObject.SetActive(false);
        puanText.gameObject.SetActive(true);
        oyunBittiText.gameObject.SetActive(false);
        PuaniGüncelle();
    }

    public void OyunBitti()
    {
        oyunBittiText.gameObject.SetActive(true);
        oynaButon.gameObject.SetActive(true);

    }



    void PuaniGüncelle()
    {
        if (!puanText.gameObject.activeInHierarchy)
        {
            puanText.gameObject.SetActive(true);  // Eðer puanText gizlendiyse tekrar aktif hale getir.
        }

        puanText.text = "PUAN: " + puan;
        Debug.Log("Puan güncellendi: " + puan);
    }


    public void AsteroidYokOldu(GameObject asteroid)
    {
        Debug.Log("Asteroid vuruldu: " + asteroid.gameObject.name); // Asteroidin adýný loglayalým.

        switch (asteroid.gameObject.name[8])
        {
            case '1':
                puan += 5;
                break;

            case '2':
                puan += 10;
                break;

            case '3':
                puan += 15;
                break;

            default:
                Debug.LogWarning("Bilinmeyen asteroid vuruldu");
                break;
        }

        PuaniGüncelle(); // Bu metot ile puan UI'da güncelleniyor.
    }

}
