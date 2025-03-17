using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    GeriSayýmSayacý geriSayýmSayaci;


    // Start is called before the first frame update
    void Start()
    {
        geriSayýmSayaci = gameObject.AddComponent<GeriSayýmSayacý>();
        geriSayýmSayaci.ToplamSure = 1;
        geriSayýmSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayýmSayaci.Bitti)
        {
            SpawnAsteroid();
            geriSayýmSayaci.Calistir();

         
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
