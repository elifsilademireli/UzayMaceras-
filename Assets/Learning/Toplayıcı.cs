using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayıcı : MonoBehaviour
{
    [SerializeField]
    GameObject yildizPrefab;

    List<GameObject> yildizlar = new List<GameObject>();

    public GameObject HedefYildiz
    {
        get
        {
            if (yildizlar.Count > 0)
            {
                return yildizlar[0];
            } 

            else 
            { 
                return null; 
            }

        }
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            Vector3 oyunDunyasiPozisyon = Camera.main.ScreenToWorldPoint(position);

            yildizlar.Add(Instantiate(yildizPrefab, oyunDunyasiPozisyon, Quaternion.identity));
        }
    }

    public void YildizYokEt(GameObject yokEdilecekYildiz)
    {
        yildizlar.Remove(yokEdilecekYildiz);
        Destroy(yokEdilecekYildiz);
    }


}
