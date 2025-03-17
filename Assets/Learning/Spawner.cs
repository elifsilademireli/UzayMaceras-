using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    GeriSay�mSayac� geriSay�mSayaci;


    // Start is called before the first frame update
    void Start()
    {
        geriSay�mSayaci = gameObject.AddComponent<GeriSay�mSayac�>();
        geriSay�mSayaci.ToplamSure = 1;
        geriSay�mSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSay�mSayaci.Bitti)
        {
            SpawnAsteroid();
            geriSay�mSayaci.Calistir();

         
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
