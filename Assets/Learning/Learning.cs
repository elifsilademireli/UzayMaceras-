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
            Debug.Log("Gemi1 kazandý");
        }
        else if(gemi1.MaksimumHiz < gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi2 kazandý");
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
        //    Debug.Log("Saldýrý altýndayýz. Düþman sayýsý: " + saldiranDusman);
        //}

        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Saldýrý altýndayýz. Düþman sayýsý: " + saldiranDusman);
        //} while (saldiriDevam);


        //int yokedilenAsteriod = 20;
        //int oyuncuHp = 100;

        //if(yokedilenAsteriod >= 10 &&  oyuncuHp == 100)
        //{
        //   Debug.Log("Mükemmel");

        //}
        //if (yokedilenAsteriod == 20)
        //{
        //    Debug.Log("Tebrikler oyunu kazandýnýz");
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
        //        Debug.Log("Güzel baþlangýç");
        //        break;
        //    case 10:
        //        Debug.Log("Bu iþte çok iyisin");
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
