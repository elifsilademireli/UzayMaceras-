using UnityEngine;

public class GeriSayımSayacı : MonoBehaviour
{
    float toplamSure = 0;
    float gecenSure = 0;

    bool calisiyor = false; // Eğer sayacın çalışıp çalışmadığını takip eder.
    bool basladi = false; // Eğer sayacın başlatılıp başlatılmadığını takip eder.

    public float ToplamSure
    {
        set
        {
            if (!calisiyor) // Eğer sayacı zaten çalışıyorsa, toplam süreyi güncelleme.
            {
                toplamSure = value;
            }
        }
    }

    public bool Bitti
    {
        get
        {
            return basladi && !calisiyor; // Sayacın başlatıldığını ve çalışmadığını kontrol eder.
        }
    }

    public void Calistir()
    {
        if (toplamSure > 0)
        {
            calisiyor = true; // Sayacı başlat.
            basladi = true; // Sayacın başlatıldığını işaretle.
            gecenSure = 0; // Geçen süreyi sıfırla.
        }
    }

    void Update()
    {
        if (calisiyor)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= toplamSure)
            {
                calisiyor = false; // Belirtilen süre dolduğunda sayacı durdur.
            }
        }
    }
}
