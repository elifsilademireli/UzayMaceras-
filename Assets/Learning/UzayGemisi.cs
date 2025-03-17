using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    
    int maksimumHiz;

    string renk;

     public int MaksimumHiz
    {
        get { return maksimumHiz; }
    }

    public string Renk
    {
        get { return renk; }
    }

    public UzayGemisi(int maksimumHiz, string renk)
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }

    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }

    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
    }

    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 15);
        Debug.Log(maksimumHiz);
    }
}
