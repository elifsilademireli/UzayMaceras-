using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{

    [SerializeField]
    GameObject patlamaPrefab;

    GeriSayýmSayacý yokEdiciGeriSayým;

    // Start is called before the first frame update
    void Start()
    {
        yokEdiciGeriSayým= gameObject.AddComponent<GeriSayýmSayacý>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSayým.Bitti)
        {
            Instantiate(patlamaPrefab,gameObject.transform.position,Quaternion.identity) ;
            Destroy(gameObject);

        }
    }

    public void AsteroidYokEdici(int sure)
    {
        yokEdiciGeriSayým.ToplamSure = sure;
        yokEdiciGeriSayým.Calistir();
    }
}
