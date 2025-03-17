using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{
    const float hareketGucu = 5; // Sabit bir hareket gücü tanýmlandý

    bool topluyor = false;

    GameObject hedef;

    Rigidbody2D myRigidbody2D;

    Toplayýcý toplayici; // Küçük "i" ile tanýmlandý

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<Toplayýcý>(); // Küçük "i" ile ayný þekilde kullanýldý
    }

    void OnMouseDown()
    {
        if (!topluyor)
        {
            GitVeTopla();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef); // Doðru metod adý
            myRigidbody2D.velocity = Vector2.zero;
            GitVeTopla();
        }
    }


    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz; // Küçük "i" ile kullanýldý
        if (hedef != null)
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();
            myRigidbody2D.AddForce(gidilecekYer * hareketGucu, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal"); // Unity'de "Horizontal" doðru girdi ismi

        //if (yatayInput != 0) // != operatörü arasýndaki boþluklar kaldýrýldý
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime;
        //}

        //float dikeyInput = Input.GetAxis("Vertical"); // Unity'de "Vertical" doðru girdi ismi
        //if (dikeyInput != 0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}

        //transform.position = position;
    }
}
