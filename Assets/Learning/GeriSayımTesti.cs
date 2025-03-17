using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayımTesti : MonoBehaviour
{
    GeriSayımSayacı geriSayımSayaci;
    float baslangıcZamani;

    // Start is called before the first frame update
    void Start()
    {
        geriSayımSayaci = gameObject.AddComponent<GeriSayımSayacı>();
        geriSayımSayaci.ToplamSure = 3;
        geriSayımSayaci.Calistir();

        baslangıcZamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayımSayaci.Bitti)
        {
            float gecenSure = Time.time - baslangıcZamani;
            Debug.Log(gecenSure);

            baslangıcZamani = Time.time;
            geriSayımSayaci.Calistir(); // Değişken adı düzeltildi
        }
    }
}
