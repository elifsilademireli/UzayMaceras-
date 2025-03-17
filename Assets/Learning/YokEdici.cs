using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{

    [SerializeField]
    GameObject patlamaPrefab;

    GeriSay�mSayac� yokEdiciGeriSay�m;

    // Start is called before the first frame update
    void Start()
    {
        yokEdiciGeriSay�m= gameObject.AddComponent<GeriSay�mSayac�>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSay�m.Bitti)
        {
            Instantiate(patlamaPrefab,gameObject.transform.position,Quaternion.identity) ;
            Destroy(gameObject);

        }
    }

    public void AsteroidYokEdici(int sure)
    {
        yokEdiciGeriSay�m.ToplamSure = sure;
        yokEdiciGeriSay�m.Calistir();
    }
}
