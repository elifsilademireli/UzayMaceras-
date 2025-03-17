using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EkranHesaplayicisi
{
    static float sol;
    static float sag;
    static float ust;
    static float alt;

    public static float Sol
    {
        get { return sol; }
    }

    public static float Sag
    {
        get { return sag; }
    }

    public static float Ust
    {
        get { return ust; }
    }

    public static float Alt
    {
        get { return alt; }
    }

    public static void Init()
    {
        float ekranZekseni= -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni);
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni);


        Vector3 solAltKoseOyunDunyasý = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseOyunDunyasý = Camera.main.ScreenToWorldPoint(sagUstKose);


        sol = solAltKoseOyunDunyasý.x;
        sag = sagUstKoseOyunDunyasý.x;
        ust = sagUstKoseOyunDunyasý.y;
        alt = solAltKoseOyunDunyasý.y;


    }


}

