using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        UzayGemisi gemi1 = new UzayGemisi(Random.Range(80,100));
        UzayGemisi gemi2 = new UzayGemisi(15,"Gri");

        gemi1.Yavaslatici();
        gemi2.Yavaslatici();

        if (gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi1 kazand�");
        }
        else if(gemi1.MaksimumHiz < gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi2 kazand�");
        }
        else
        {
            Debug.Log("Berabere");

        }

        //int saldiranDusman = 10;
        //bool saldiriDevam = false;

        //while (saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if(saldiranDusman < 3)
        //    {
        //        saldiriDevam = false; 
        //        saldiriDevam = false; 
        //    }
        //    Debug.Log("Sald�r� alt�nday�z. D��man say�s�: " + saldiranDusman);
        //}

        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Sald�r� alt�nday�z. D��man say�s�: " + saldiranDusman);
        //} while (saldiriDevam);


        //int yokedilenAsteriod = 20;
        //int oyuncuHp = 100;

        //if(yokedilenAsteriod >= 10 &&  oyuncuHp == 100)
        //{
        //   Debug.Log("M�kemmel");

        //}
        //if (yokedilenAsteriod == 20)
        //{
        //    Debug.Log("Tebrikler oyunu kazand�n�z");
        //}
        //else if (yokedilenAsteriod == 25)
        //{
        //    Debug.Log("Tebrikler birincisin");
        //}
        //else
        //{
        //    Debug.Log("Tebrikler oyunu kaybettiniz");
        //}

        //switch (yokedilenAsteriod)
        //{
        //    case 1:
        //        Debug.Log("G�zel ba�lang��");
        //        break;
        //    case 10:
        //        Debug.Log("Bu i�te �ok iyisin");
        //        break;
        //    default:
        //        Debug.Log("Maalesef oyunu kaybettiniz");
        //        break;
        //}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
